using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_ShowsCore.Models
{
    public class Cars
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Cost { get; set; }
        public int MotoShowsID { get; set; }

        public MotoShows MotoShows { get; set; }
        public ICollection<Clients> Clients { get; set; }
    }
}
