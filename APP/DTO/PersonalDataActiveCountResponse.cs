using System.ComponentModel.DataAnnotations;

namespace APP.DTO
{
    public class PersonalDataActiveCountResponse
    {
        public string PersonalID { get; set; }
        public string FullName { get; set; }
        public string ContractType { get; set; }
        public int JumlahIdentity { get; set; }

    }
}
