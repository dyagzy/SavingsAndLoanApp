using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication
{
    public class CommonProperty
    {
        public DateTime Created { get; set; } = new DateTime(1900, 1, 1);
        public DateTime Updated { get; set; } = new DateTime(1900, 1, 1);
        public string Message { get; set; }

    }
}
