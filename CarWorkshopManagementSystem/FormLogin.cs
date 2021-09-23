using CarWorkshopManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshopManagementSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            //FormSignUp fsu = new FormSignUp();
            //fsu.ShowDialog();
            //this.Hide();

            this.Hide();
            FormSignUp fsu = new FormSignUp();
            fsu.ShowDialog();
            this.Close();
        }

        private void kryptonBtnSignIn_Click(object sender, EventArgs e)
        {
            kryptonBtnSignIn.BackColor = Color.FromArgb(0, 0, 165);
            kryptonBtnSignIn.ForeColor = Color.Gainsboro;

            this.Hide();
            //Application.Run(new FormHomePage());
            FormHomePage f1 = new FormHomePage();
            f1.ShowDialog();
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
