using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Repository
{
    public class GameSetting
    {
        public static int AreaWidth { get; set; }//3
        public static int AreaHeight { get; set; }//4
        public int AreaId { get; set; }
        public int AreaOwnerId { get; set; }
        public string Name { get; set; }
        public void SetArea(List<KryptonCheckButton> buttons)
        {

            for (int i = 0; i < AreaHeight; i++)
            {
                for (int j = 0; j < AreaWidth; j++)
                {
                    buttons[i + (j * 5)].Visible = true;
                }
            }

        }
    }
}
