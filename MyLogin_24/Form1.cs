using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogin_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BelajarDataContext db = new BelajarDataContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = (from s in db.TB_M_USERs where s.Username == txtUsername.Text select s).First();
            if (user.Password == txtPass.Text)
            {
                this.Hide();
                MasterProduct a = new MasterProduct();
                a.Show();
            }
            else
            {
                MessageBox.Show("Password Error");
            }
        }
    }
}