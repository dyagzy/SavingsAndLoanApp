using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class CustomerListDto
    {
        public byte CustomerImage { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public string PhoneNumber { get; set; }
    }
}
