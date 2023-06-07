using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaLand.Repository;

namespace MetaLand
{
    public partial class Home : Form
    {
        Database db = new Database();
        public Home()
        {
            InitializeComponent();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtUNickname.Clear();
            txtPass.Clear();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.UserNickname = txtUNickname.Text;
            User.Password = txtPass.Text;
            int islogin = db.Login();
            if (islogin == 0)
            {
                if (Amount.AmountFood <= 0 || Amount.AmountItem <= 0 || Amount.AmountMoney <= 0)
                {
                    GameOver overform = new GameOver();
                    overform.Show();
                    overform.FormClosed += form_FormClosed;
                    this.Hide();
                    return;
                }
                Game gameform = new Game();
                gameform.Show();
                gameform.FormClosed += form_FormClosed;
                this.Hide();
            }
            else if (islogin == 1)
            {
                if (Amount.AmountFood <= 0 || Amount.AmountItem <= 0 || Amount.AmountMoney <= 0)
                {
                    GameOver overform = new GameOver();
                    overform.Show();
                    overform.FormClosed += form_FormClosed;
                    this.Hide();
                    return; 
                }
                Manager manager = new Manager();
                manager.FormClosed += form_FormClosed;
                manager.Show();
                this.Hide();
            }
            else if (islogin == 2)
            {
                label3.Text = "Şifreler Uyuşmuyor!!!";
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            txtPass.PasswordChar = '*';
            txtRpass.PasswordChar = '*';
            txtRepass.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
            btnDirectory.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pnlLogin.Visible = true;
            pnlRegister.Visible = false;
            btnDirectory.Visible = true;
        }

        private void btnRegistera_Click(object sender, EventArgs e)
        {
            if (txtRpass.Text != txtRepass.Text)
            {
                label1.Text = "Şifreler Uyuşmuyor!!!";
            }
            else
            {
                User.UserName = txtRName.Text;
                User.UserSurname = txtRSurname.Text;
                User.UserNickname = txtNickname.Text;
                User.Password = txtRpass.Text;
                User.StartDate = DateTime.Now;

                pnlRegister.Visible = false;
                pnlLogin.Visible = true;
                btnDirectory.Visible = false;
                db.Register(0);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Manager us = new Manager();
            us.Show();
            this.Close();
        }
    }
}
