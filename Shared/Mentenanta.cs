using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenancePlatform.Shared
{
    class Mentenanta
    {
        public int Id { get; set; }
        public string Descriere { get; set; }
        public DateTime Data { get; set; }
        public string Semnatura { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
