using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APP.Entities
{
    [Table("PersonalData")]
    public class PersonalData
    {
        [Key]
        public string PersonalID { get; set; }
        public string FullName { get; set; }
        public string ContractType { get; set; }
    }
}
