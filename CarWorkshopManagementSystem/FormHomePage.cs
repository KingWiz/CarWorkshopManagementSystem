using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshopManagementSystem
{

    
    public partial class FormHomePage : Form
    {
        //public class RoundButton : Button
        //{
        //    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        //    {
        //        GraphicsPath grPath = new GraphicsPath();
        //        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        //        this.Region = new System.Drawing.Region(grPath);
        //        base.OnPaint(e);
        //    }
        //}

        //Constructor
        public FormHomePage()
        {
            InitializeComponent();
            //random = new Random();
        }

        //Feilds
        private Button currentButton;
        //private Random random;    //Used for multicolor
        private int tempIndex;
        private Form activeForm;

        //Methods
        /*
         * used for multicolor
         
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        */

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    /*
                     * Multiple colors
                     
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ;

                    */
                    //Color color = Color.FromArgb(0, 148, 188);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Indigo;
                    currentButton.ForeColor = Color.Gainsboro;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;


                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in tlpMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    //previousBtn.BackColor = Color.FromArgb(0, 0, 165);
                    btnHome.BackColor = Color.FromArgb(20, 4, 55);
                    btnHome.ForeColor = Color.Gainsboro;
                    btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    previousBtn.BackColor = Color.FromArgb(20, 4, 55);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //private void OpenChildForm(Form childForm, object btnSender)
        //{
        //    if(activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    ActivateButton(btnSender);
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    this.panelDesktop.Controls.Add(childForm);
        //    this.panelDesktop.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //    lblTitle.Text = childForm.Text;

        //}

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            //uC_AddCustomer1.Visible = false;
            //uC_Search1.Visible = false;
            //uC_Tasks1.Visible = false;
            //uC_HomePage1.Visible = true;
            //uC_HomePage1.BringToFront();

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //uC_HomePage1.Visible = true;
            //uC_HomePage1.BringToFront();
            lblTitle.Text = btnHome.Text;
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //uC_AddCustomer1.Visible = true;
            //uC_AddCustomer1.BringToFront();
            lblTitle.Text = btnAddCustomer.Text;
        }
        private void btnTotalCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //uC_TotalCustomers1.Visible = true;
            //uC_TotalCustomers1.BringToFront();
            lblTitle.Text = btnTotalCustomers.Text;
            //uC_TotalCustomers1.DisplayCustomersData();
            //OpenChildForm(new Forms.FormTotalCars(), sender);
        }
        private void btnReleaseCar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = btnReleaseCar.Text;
            //uC_ReleaseCar1.Visible = true;
            //uC_ReleaseCar1.BringToFront();
            //OpenChildForm(new Forms.FormSellCar(), sender);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = btnSearch.Text;
            //uC_Search1.Visible = true;
            //uC_Search1.BringToFront();
            //OpenChildForm(new Forms.FormSellCar(), sender);
        }
        private void btnTasks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = btnTasks.Text;
            //uC_Tasks1.Visible = true;
            //uC_Tasks1.BringToFront();
            //OpenChildForm(new Forms.FormSellCar(), sender);
        }
        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = btnUpdateDelete.Text;
            //uC_UpdateOrDelete1.Visible = true;
            //uC_UpdateOrDelete1.BringToFront();
            //uC_AddCustomer1.ClearCustomersText();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = btnExit.Text;
            Application.Exit();
        }
        private void llblSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            this.Close();
            fl.ShowDialog();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            lblTitle.Text = btnAddCustomer.Text;
        }

    }
}
