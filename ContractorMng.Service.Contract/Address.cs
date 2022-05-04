using System.Runtime.Serialization;

namespace ContractorMng.Service.Contract
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public int AddressId { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string BuildingNo { get; set; }

        [DataMember]
        public string FlatNo { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string Post { get; set; }

        [DataMember]
        public string Community { get; set; }

        [DataMember]
        public string District { get; set; }

        [DataMember]
        public string Province { get; set; }

        [DataMember]
        public string Country { get; set; }
    }
}