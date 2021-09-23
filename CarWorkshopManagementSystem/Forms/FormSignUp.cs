using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshopManagementSystem.Forms
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void kryptonBtnBack_Click(object sender, EventArgs e)
        {
            //FormLogin fl = new FormLogin();
            //fl.ShowDialog();
            //this.Hide();

            this.Hide();
            this.Close();
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            //this.Close();
        }
    }
}
