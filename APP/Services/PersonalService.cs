using APP.DbContexts;
using APP.DTO;

namespace APP.Services
{
    public class PersonalService:IPersonalService
    {
        private ApplicationDbContext _db;

        public PersonalService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<PersonalDataSimActiveResponse> GetPersonalDataSimActiveResponse()
        {
            var today = DateTime.Today;

            var query = _db.PersonalDatas
                            .Join(_db.PersonalIdentities,
                                  pd => pd.PersonalID,
                                  pid => pid.PersonalID,
                                  (pd, pid) => new { pd, pid })
                            .Where(x => x.pid.ExpiredDate > today &&
                                        x.pid.IdentityType.Contains("SIM"))
                            .Select(x => new PersonalDataSimActiveResponse
                            {
                                PersonalID = x.pd.PersonalID,
                                FullName = x.pd.FullName,
                                ContractType = x.pd.ContractType,
                                IdentityType = x.pid.IdentityType,
                                ExpiredDate = x.pid.ExpiredDate
                            });
            var results = query.ToList();
            return results;
        }

        public List<PersonalDataActiveCountResponse> GetPersonalDataActiveCountResponse()
        {
            var query = from pd in _db.PersonalDatas
                        join pid in _db.PersonalIdentities
                        on pd.PersonalID equals pid.PersonalID
                        where pid.ExpiredDate > DateTime.Today // Compare with current date without time
                        group pd by new { pd.PersonalID, pd.FullName, pd.ContractType } into g
                        select new PersonalDataActiveCountResponse
                        {
                            PersonalID = g.Key.PersonalID,
                            FullName = g.Key.FullName,
                            ContractType = g.Key.ContractType,
                            JumlahIdentity = g.Count()
                        };

            var results = query.ToList();
            return results;
        }
    }
}
