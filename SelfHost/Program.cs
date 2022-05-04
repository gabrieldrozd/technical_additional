using ContractorMng.Service;
using System;
using System.ServiceModel;

namespace SelfHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceSelfHostContractor = null;

            try
            {
                serviceSelfHostContractor = new ServiceHost(typeof(ContractorService));

                serviceSelfHostContractor.Open();

                Console.WriteLine("Hosting został uruchomiony");
                Console.WriteLine("Serwisy nasłuchują żądań klientów na adresach:");
                Console.WriteLine();

                foreach (var endpoint in serviceSelfHostContractor.Description.Endpoints)
                {
                    Console.WriteLine($"Adres: {endpoint.Address} Wiązanie: {endpoint.Binding.Name}");
                }

                Console.WriteLine();
                Console.WriteLine("Wciśnięcie dowolnego klawisza kończy pracę");
                Console.ReadKey();

                serviceSelfHostContractor.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                if (serviceSelfHostContractor != null && serviceSelfHostContractor.State == CommunicationState.Opened)
                    serviceSelfHostContractor.Close();
            }
        }
    }
}
