using ComponentFactory.Krypton.Toolkit;
using MetaLand.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MetaLand
{
    public partial class Game : Form
    {

        private Timer timer;
        private int seconds;
        public int alanID { get; set; }

        public Game()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timerJob_Tick;
        }
        static Database db = new Database();
        KullaniciIslem kullaniciIslem = db.KullaniciIslem;
        Business business = db.Business;
        GameSetting gameSetting = new GameSetting();
        public static List<KryptonCheckButton> buttonlist = new List<KryptonCheckButton>();
        List<KeyValuePair<string, int>> buttonNamesFromDatabase = db.PullAreaName();
        public void addlistButton()
        {
            if (buttonlist.Count == 20)
            {
                buttonlist.Clear();
            }
            for (int i = 1; i < 21; i++)
            {
                string buttonName = "Area" + i.ToString();
                KryptonCheckButton button = Controls.Find(buttonName, true).FirstOrDefault() as KryptonCheckButton;

                if (button != null)
                {
                    buttonlist.Add(button);
                }
            }

            for (int i = 0; i < buttonlist.Count; i++)
            {
                buttonlist[i].Text = buttonNamesFromDatabase[i].Key;
            }
        }
        int count = 0;

        private void ButtonClick(object sender, EventArgs e)
        {
            KryptonCheckButton clickedButton = (KryptonCheckButton)sender;
            string buttontext = clickedButton.Text;
            if (clickedButton.Text.Contains("Boş"))
            {
                clickedButton.Checked = false;
                MessageBox.Show("Bu alan hizmete açık değildir emlak noktalarından satın alabilirsiniz");
                return;
            }

            KeyValuePair<string, int> foundItem = buttonNamesFromDatabase.FirstOrDefault(item => item.Key == buttontext);

            if (foundItem.Key != null)
            {
                string alanAd = foundItem.Key;
                alanID = foundItem.Value;
                db.PullBusinessData(alanID);
            }
            if (db.Business.IsletmeTurID != 3)
            {
                pnlDeal.Visible = true;
                pnlUrun.Visible = true;
                pnlDeal.Location = new Point(432, 613);
                pnlKiralama.Visible = false;
                pnlSatis.Visible = false;
            }
            else
            {
                pnlKiralama.Visible = true;
                pnlSatis.Visible = true;
                pnlDeal.Visible = true;
                pnlDeal.Location = new Point(723, 613);
                pnlUrun.Visible = false;
                if (count < 1)
                {
                    foreach (KeyValuePair<string, int> item in buttonNamesFromDatabase)
                    {
                        cmbArsaSat.Items.Add(item.Key);
                        cmbArsaKira.Items.Add(item.Key);
                    }
                    count++;
                }
            }

        }
        private void Button_CheckedChanged(object sender, EventArgs e)
        {
            KryptonCheckButton clickedButton = (KryptonCheckButton)sender;

            if (clickedButton.Checked)
            {
                foreach (KryptonCheckButton button in buttonlist)
                {
                    if (button != clickedButton)
                    {
                        button.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (KryptonCheckButton button in buttonlist)
                {
                    button.Enabled = true;
                    pnlDeal.Visible = false;
                    pnlKiralama.Visible = false;
                    pnlSatis.Visible = false;
                    pnlUrun.Visible = false;
                }
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            db.PullGameAreaData();
            addlistButton();
            lblItemData.Text = Amount.AmountItem.ToString();
            lblFoodData.Text = Amount.AmountFood.ToString();
            lblMoneyData.Text = Amount.AmountMoney.ToString();

            if (Amount.AmountFood <= 10 || Amount.AmountItem <= 10 || Amount.AmountMoney <= 10)
            {
                lblDescription.Text = "Eşya para ya da yiyecek miktarınız çok düşük lütfen gerekli dükkanlardan alınız";
            }

            for (int i = 1; i <= 24; i++)
            {
                cmbWorkHour.Items.Add(i);
                cmbUrunAdet.Items.Add(i);
            }

            if (GameSetting.AreaWidth <= 3 && GameSetting.AreaHeight <= 3)
            {
                this.Size = new Size(800, 600);
                pnlInfo.Location = new Point(633, 3);
                pnlDeal.Location = new Point(3, 400);
                pnlUrun.Location = new Point(379, 400);
                pnlSatis.Location = new Point(660, 400);
            }
            db.PullAreaName();
            gameSetting.SetArea(buttonlist);
        }

        private void timerJob_Tick(object sender, EventArgs e)
        {
            this.seconds++;

            TimeSpan time = TimeSpan.FromSeconds(this.seconds);

            // Saat, dakika ve saniye bilgisini al
            int hours = time.Hours;
            int minutes = time.Minutes;
            int seconds = time.Seconds;

            string timeString = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

            panel1.Enabled = false;
            if (Convert.ToInt32(cmbWorkHour.Text) == seconds)
            {
                db.PullAmountDataUser();
                lblItemData.Text = Amount.AmountItem.ToString();
                lblFoodData.Text = Amount.AmountFood.ToString();
                lblMoneyData.Text = Amount.AmountMoney.ToString();
                if (Amount.AmountFood <= 0 || Amount.AmountItem <= 0 || Amount.AmountMoney <= 0)
                {
                    GameOver gameOverform = new GameOver();
                    gameOverform.Show();
                    this.Close();
                }
                panel1.Enabled = true;

                timer.Stop();
                lblDescription.Text = "Çalışma süresi doldu gerekli eklemeler yapıldı";
            }
            if (Convert.ToInt32(cmbWorkHour.Text) < seconds)
            {
                this.seconds = 0;
            }
            label3.Text = timeString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDetail userDetailform = new UserDetail();
            userDetailform.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e)//Urun alma 
        {
            int money = Convert.ToInt32(lblTutar.Text);

            db.CalismaIslemiKullaniciGonder(money, alanID);
            timer.Start();
        }

        private void cmbWorkHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTutar.Text = (db.Business.SaatlikUcret * Convert.ToInt32(cmbWorkHour.Text)).ToString();
            lblKazanc.Text = db.Business.IsletmeTurID == 1 ? "Yemek ücretsiz" : (db.Business.IsletmeTurID == 2 ? "Eşya ücretsiz" : "Para eksiltmesi olmayacak");

        }
        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            int TotalFiyat = Convert.ToInt32(lblUrunTutar.Text);
            if (Amount.AmountMoney <= TotalFiyat)
            {
                MessageBox.Show("Bu işlemi yapamazsınız");
                return;
            }
            db.setUrunAlma(TotalFiyat);
            string urunislemi = "Urun Alma";
            db.KullaniciIslemKaydet(urunislemi);
            db.PullAmountDataUser();
            lblItemData.Text = Amount.AmountItem.ToString();
            lblFoodData.Text = Amount.AmountFood.ToString();
            lblMoneyData.Text = Amount.AmountMoney.ToString();

        }

        private void cmbUrunAdet_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUrunCins.Text = db.Business.IsletmeTurID == 1 ? "Yemek" : "Eşya";
            lblUrunTutar.Text = (db.Business.IsletmeUrunFiyat * Convert.ToInt32(cmbUrunAdet.Text)).ToString();
        }

        private void cmbArsaKira_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buttontext = cmbArsaKira.Text;
            KeyValuePair<string, int> foundItem = buttonNamesFromDatabase.FirstOrDefault(item => item.Key == buttontext);
            int id = foundItem.Value;
            db.PullBusinessData(id);
            db.pullEmlakData();

            lblEmlakKiraTutar.Text = db.Emlak.IsletmeKiraUcreti.ToString();
        }

        private void btnDismiss1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblTutar.Text = "";
            lblKazanc.Text = string.Empty;

        }

        private void btnDissmiss_Click(object sender, EventArgs e)
        {
            cmbUrunAdet.Text = "";
            lblUrunTutar.Text = "";
            lblUrunCins.Text = "";
        }

        private void btnEmlakSat_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(lblEmlakSatTutar.Text) + Convert.ToInt32(lblKomisyonSat.Text);
            lblEmlakSatTutar.Text = db.Emlak.IsletmeSatisUcreti.ToString();
            lblKomisyonSat.Text = db.Emlak.AliciKomisyon.ToString();
            db.EmlakSatIslem();
            db.BakiyeDüs();
        }

        private void cmbArsaSat_SelectedIndexChanged(object sender, EventArgs e)
        {

            KeyValuePair<string, int> foundItem = buttonNamesFromDatabase.FirstOrDefault(item => item.Key == cmbArsaSat.Text);
            int id = foundItem.Value;
            db.PullBusinessData(id);
            db.pullEmlakData();

            lblEmlakSatTutar.Text = db.Emlak.IsletmeSatisUcreti.ToString();
            lblKomisyonSat.Text = db.Emlak.AliciKomisyon.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbArsaSat.Text = string.Empty;
        }

        private void btnEmlakKira_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(lblEmlakKiraTutar.Text);
            if (Amount.AmountMoney <= total)
            {
                lblDescription.Text = "Eşya para ya da yiyecek miktarınız çok düşük lütfen gerekli dükkanlardan alınız";
            }
        }
    }
}
