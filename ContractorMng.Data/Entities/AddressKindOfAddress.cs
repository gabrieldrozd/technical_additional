using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractorMgn.Data.Entities
{
    public class AddressKindOfAddress
    {
        [ForeignKey("Address")]
        public int AddressId { get; set; }

        [ForeignKey("KindOfAddress")]
        public int KindOfAddressId { get; set; }
    }
}
