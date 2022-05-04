using System;
using System.Collections.Generic;
using System.Linq;
using ContractorMng.Data.Entities;
using ContractorMng.Data.Repositories;
using ContractorMng.Service.Contract;
using Address = ContractorMng.Service.Contract.Address;
using Contractor = ContractorMng.Service.Contract.Contractor;

namespace ContractorMng.Service
{
    public class ContractorService : IContractorService
    {
        public Contractor GetContractorByName(string name)
        {
            IContractorRepository contractorRepository = new ContractorRepository();

            var contractor = contractorRepository.Get(name);

            return GetContractor(contractor);
        }

        public Contractor GetContractorById(int id)
        {
            IContractorRepository contractorRepository = new ContractorRepository();

            var contractor = contractorRepository.Get(id);

            return GetContractor(contractor);
        }

        private Contractor GetContractor(Data.Entities.Contractor contractor)
        {
            Contractor result = null;

            if (contractor != null)
            {
                var address = contractor.Addresses
                    .FirstOrDefault(a => a.KindOfAddresses
                        .Any(k => k.Code == KindOfAddressCode.Main)
                    );

                result = new Contractor
                {
                    ContractorId = contractor.ContractorId,
                    Name = contractor.Name,
                    Nip = contractor.Nip,
                    Email = contractor.Email,
                    PhoneNo = contractor.PhoneNo
                };

                if (address != null)
                {
                    result.MainAddress = new Contract.Address()
                    {
                        AddressId = address.AddressId,
                        City = address.City,
                        Street = address.Street,
                        BuildingNo = address.BuildingNo,
                        FlatNo = address.FlatNo,
                        PostalCode = address.PostalCode,
                        Post = address.Post,
                        Community = address.Community,
                        District = address.District,
                        Province = address.Province,
                        Country = address.Country
                    };
                }
            }

            return result;
        }

        public IEnumerable<Contractor> GetAllContractors()
        {
            var result = new List<Contractor>();
            IContractorRepository contractorRepository = new ContractorRepository();

            foreach (var contractor in contractorRepository.Get())
            {
                result.Add(new Contractor
                {
                    ContractorId = contractor.ContractorId,
                    Name = contractor.Name,
                    Nip = contractor.Nip,
                    Email = contractor.Email,
                    PhoneNo = contractor.PhoneNo
                });
            }

            return result;
        }

        public IEnumerable<Address> GetAllContractorAddresses(int id)
        {
            var result = new List<Address>();
            IContractorRepository contractorRepository = new ContractorRepository();

            foreach (var address in contractorRepository.GetAllAddresses(id))
            {
                result.Add(new Address
                {
                    AddressId = address.AddressId,
                    City = address.City,
                    Street = address.Street,
                    BuildingNo = address.BuildingNo,
                    FlatNo = address.FlatNo,
                    PostalCode = address.PostalCode,
                    Post = address.Post,
                    Community = address.Community,
                    District = address.District,
                    Province = address.Province,
                    Country = address.Country
                });
            }

            return result;
        }

        public Contractor AddContractor(string name, string nip, string phoneNo, string email, string city,
            string street, string buildingNo, string postalCode, string country)
        {
            IContractorRepository contractorRepository = new ContractorRepository();

            contractorRepository.Add(name, nip, phoneNo, email, city,
                street, buildingNo, postalCode, country);

            var contractor = contractorRepository.Get(name);

            return GetContractor(contractor);
        }
    }
}
