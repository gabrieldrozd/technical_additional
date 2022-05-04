using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorMng.Data.Dtos
{
    public class ContractorDto
    {
        public int ContractorId { get; set; }
        public string Name { get; set; }
        public string Nip { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
