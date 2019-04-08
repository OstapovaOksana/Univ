using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_ShowsCore.Models
{
    public class Clients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Telephone { get; set; }
        public int CarsID { get; set; }

        public Cars Cars { get; set; }
    }
}
