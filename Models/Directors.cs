using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moto_ShowsCore.Models
{
    public class Directors
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<MotoShows> MotoShows { get; set; }
    }
}
