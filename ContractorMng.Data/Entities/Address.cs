using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractorMng.Data.Entities
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [ForeignKey("Contractor")]
        public int ContractorId { get; set; }
        public Contractor Contractor { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        [Required]
        [StringLength(10)]
        public string BuildingNo { get; set; }
        
        [StringLength(10)]
        public string FlatNo { get; set; }

        [Required]
        [StringLength(6)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Post { get; set; }

        [StringLength(50)]
        public string Community { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        public ICollection<KindOfAddress> KindOfAddresses { get; set; }

        public Address()
        {
            KindOfAddresses = new List<KindOfAddress>();
        }
    }
}
