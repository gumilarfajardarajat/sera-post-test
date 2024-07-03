using APP.DTO;

namespace APP.Services
{
    public interface IPersonalService
    {
        public List<PersonalDataSimActiveResponse> GetPersonalDataSimActiveResponse();
        public List<PersonalDataActiveCountResponse> GetPersonalDataActiveCountResponse();

    }
}
