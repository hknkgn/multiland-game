using MetaLand.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaLand
{
    public partial class UserDetail : Form
    {
        public UserDetail()
        {
            InitializeComponent();
        }

        private void UserDetail_Load_1(object sender, EventArgs e)
        {
            Database db = new Database();
            
            dataGridView3.DataSource = db.userDetail();
            dataGridView2.DataSource = db.userDetailInfo();

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }
    }
}
