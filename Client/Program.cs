using ContractorMng.Service;
using ContractorMng.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContractorService _contractorServiceClient = new ChannelFactory<IContractorService>("ContractorService").CreateChannel();
            Console.WriteLine("1. Wypisanie wszystkich contractorĂłw");
            var caseOpt = Console.ReadLine();
            switch (caseOpt)
            {
                case "1":
                    var contractors = _contractorServiceClient.GetAllContractors();
                    foreach (var item in contractors)
                    {
                        Console.WriteLine("Id: " + item.ContractorId);
                        Console.WriteLine("Email: " + item.Email);
                        Console.WriteLine("Name: " + item.Name);
                        Console.WriteLine("Nip: " + item.Nip);
                        Console.WriteLine("PhoneNo: " + item.PhoneNo);
                        Console.WriteLine();
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
