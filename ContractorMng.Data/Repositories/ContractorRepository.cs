using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ContractorMng.Data.Entities;

namespace ContractorMng.Data.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly ContractorContext _contractorContext;

        public ContractorRepository()
        {
            _contractorContext = null;
        }

        public ContractorRepository(ContractorContext contractorContext)
        {
            _contractorContext = contractorContext;
        }

        public Contractor Get(int id)
        {
            using (var context = _contractorContext ?? new ContractorContext())
            {
                return context.Contractors
                    .Where(c => c.ContractorId == id)
                    .Include("Addresses.KindOfAddresses")
                    //.Include(c=>c.Addresses.Select(k=>k.KindOfAddresses))
                    //.Include("Addresses")//c=>c.Addresses)
                    .FirstOrDefault();
            }
        }

        public Contractor Get(string name)
        {
            using (var context = _contractorContext ?? new ContractorContext())
            {
                return context.Contractors
                    .Where(c=>c.Name.ToUpper() == name.ToUpper())
                    .Include("Addresses.KindOfAddresses")
                    //.Include(c=>c.Addresses.Select(k=>k.KindOfAddresses))
                    //.Include("Addresses")//c=>c.Addresses)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<Contractor> Get()
        {
            using (var context = _contractorContext ?? new ContractorContext())
            {
                return context.Contractors.ToList();
            }
        }

        public IEnumerable<Address> GetAllAddresses(int contractorId)
        {
            using (var context = _contractorContext ?? new ContractorContext())
            {
                return context.Addresses
                    .Where(a => a.ContractorId == contractorId)
                    .ToList();
            }
        }

        public void Add(string name, string nip, string phoneNo, string email,
            string city, string street, string buildingNo, string postalCode, string country)
        {
            using (var context = _contractorContext ?? new ContractorContext())
            {
                var kindOfAddress = context.KindOfAddresses.FirstOrDefault(k => k.Code == KindOfAddressCode.Main);

                var mainAddress = new Address
                {
                    City = city,
                    Street = street,
                    BuildingNo = buildingNo,
                    PostalCode = postalCode,
                    Country = country
                };

                mainAddress.KindOfAddresses.Add(kindOfAddress);

                var contractor = new Contractor
                {
                    Name = name,
                    Nip = nip,
                    PhoneNo = phoneNo,
                    Email = email
                };

                contractor.Addresses.Add(mainAddress);

                context.Contractors.Add(contractor);

                context.SaveChanges();
            }
        }
    }
}