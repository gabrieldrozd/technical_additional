using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractorMng.Data.Entities
{
    [Table("Contractor")]
    public class Contractor
    {
        [Key]
        public int ContractorId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(10)]
        public string Nip { get; set; }
        
        [StringLength(20)]
        public string PhoneNo { get; set; }
        
        [StringLength(50)]
        public string Email { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public Contractor()
        {
            Addresses = new List<Address>();
        }
    }
}
