using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Repository
{
    public class Business 
    {
        public int IsletmeID { get; set; }
        public int CalisanSayisi { get; set; }
        public int Kapasite { get; set; }
        public int SaatlikUcret { get; set; }
        public int  ArsaId { get; set; }
        public int IsletmeSahibiID { get; set; }
        public int IsletmeTurID { get; set; }
        public int IsletmeUrunFiyat { get; set; }
        public static List<Business> Isletme { get; set; } = new List<Business>();

    }
}
