using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MetaLand.Repository
{
    public class KullaniciIslem
    {
        public int Kimden { get; set; }
        public string Kime { get; set; }
        public string Olay { get; set; }
        public DateTime GerceklesmeZamani { get; set; } = DateTime.Now;

    }
}
