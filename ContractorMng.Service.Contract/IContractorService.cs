using System.Collections.Generic;
using System.ServiceModel;

namespace ContractorMng.Service.Contract
{
    [ServiceContract]
    public interface IContractorService
    {
        [OperationContract]
        Contractor GetContractorByName(string name);

        [OperationContract]
        Contractor GetContractorById(int id);

        [OperationContract]
        IEnumerable<Contractor> GetAllContractors();

        [OperationContract]
        IEnumerable<Address> GetAllContractorAddresses(int id);

        [OperationContract]
        Contractor AddContractor(string name, string nip, string phoneNo, string email,
            string city, string street, string buildingNo, string postalCode, string country);
    }
}
