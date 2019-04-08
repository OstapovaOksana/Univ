using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_ShowsCore.Models
{
    public class Subdivisions
    {
        public int ID { get; set; }
        public int NumberOfEmployee { get; set; }
        public int MotoShowsID { get; set; }

        public MotoShows MotoShows { get; set; }
    }
}
