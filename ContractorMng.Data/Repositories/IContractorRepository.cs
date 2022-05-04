using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Text;
using System.Threading.Tasks;
using ContractorMng.Data.Dtos;
using ContractorMng.Data.Entities;

namespace ContractorMng.Data.Repositories
{
    public interface IContractorRepository
    {
        Contractor Get(string name);

        Contractor Get(int id);

        IEnumerable<Contractor> Get();

        IEnumerable<Address> GetAllAddresses(int contractorId);

        void Add(string name, string nip, string phoneNo, string email, 
            string city, string street, string buildingNo, string postalCode, string country);
    }
}

//return new[]
//{
//    new Contractor()
//    {
//        ContractorId = 1,
//        Name = "WSIZ",
//        Nip = "1234567890",
//        Email = "wsiz@wsiz.edu.pl",
//        PhoneNo = "178660000"
//    },
//    new Contractor()
//    {
//        ContractorId = 2,
//        Name = "UR",
//        Nip = "0987654321",
//        Email = "ur@ur.edu.pl",
//        PhoneNo = "179999999"
//    }
//};

