using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Repository
{
    public class Emlak
    {
        public int IsletmeId { get; set; }
        public int IsletmeSatisUcreti { get; set; }
        public int IsletmeKiraUcreti { get; set; }
        public int AliciKomisyon { get; set; }
        public int SaticiKomisyon { get; set; }
        public int SatinAlanKiralayanKullaniciID { get; set; }
        public int SatanKiralayanKullaniciID { get; set; }
        public DateTime IslemTarihi { get; set; }
        public DateTime KiraBitisTarihi { get; set; }
    }
}
