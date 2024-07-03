using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APP.Entities
{
    [Table("PersonalIdentity")]
    public class PersonalIdentity
    {
        [Key]
        public string PersonalID { get; set; }
        public string IdentityType { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}
