using System.ComponentModel.DataAnnotations;

namespace APP.DTO
{
    public class PersonalDataSimActiveResponse
    {
        public string PersonalID { get; set; }
        public string FullName { get; set; }
        public string ContractType { get; set; }
        public string IdentityType { get; set; }
        public DateTime ExpiredDate { get; set; }
    }

}
