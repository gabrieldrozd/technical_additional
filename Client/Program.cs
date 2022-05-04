using ContractorMng.Service.Contract;
using System;
using System.ServiceModel;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContractorService _contractorServiceClient = new ChannelFactory<IContractorService>("ContractorService").CreateChannel();
            Console.WriteLine("Naciśnij dowolny klawisz, aby wypisać wszystkich Contractors...");
            Console.ReadLine();
            
            var contractors = _contractorServiceClient.GetAllContractors();
            foreach (var contractor in contractors)
            {
                Console.WriteLine("Name: " + contractor.Name);
                Console.WriteLine("Email: " + contractor.Email);
                Console.WriteLine("PhoneNo: " + contractor.PhoneNo);
                Console.WriteLine("Nip: " + contractor.Nip);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
