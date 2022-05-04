using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractorMng.Data.Entities
{
    public enum KindOfAddressCode
    {
        Main = 1,
        Office,
        Branch,
        Mailing
    }

    [Table("KindOfAddress")]
    public class KindOfAddress
    {
        [Key] 
        public int KindOfAddessId { get; set; }
        
        [Required] 
        [StringLength(50)] 
        public string Name { get; set; }
        
        [Required] 
        public KindOfAddressCode Code { get; set; }
        
        public ICollection<Address> Addresses { get; set; }
    }
}
