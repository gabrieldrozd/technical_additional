using System.Runtime.Serialization;

namespace ContractorMng.Service.Contract
{
    [DataContract]
    public class Contractor
    {
        [DataMember]
        public int ContractorId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Nip { get; set; }

        [DataMember]
        public string PhoneNo { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public Address MainAddress { get; set; }
    }
}