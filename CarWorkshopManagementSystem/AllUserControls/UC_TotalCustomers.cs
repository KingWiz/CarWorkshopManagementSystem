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

namespace CarWorkshopManagementSystem.AllUserControls
{
    public partial class UC_TotalCustomers : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OJFKR3C\SQLEXPRESS;Initial Catalog=CarWorkshopManagementSystem;Integrated Security=True");
        
        public UC_TotalCustomers()
        {
            InitializeComponent();
        }

        private void UC_TotalCustomers_Load(object sender, EventArgs e)
        {
            DisplayCustomersData();
        }
        public void DisplayCustomersData()
        {
            try
            {
                //Open Sql COnnection
                conn.Open();

                string query = "Select CustomerID,CustomerFirstName+' '+CustomerLastName as CustomerName,CustomerGender,CustomerPhoneNo,CustomerEmail,CustomerAddress,CustomerCity,CustomerState from CustomersData";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvCustomersData.Rows.Clear();

                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    dgvCustomersData.Rows.Add(sn, dataRow["CustomerID"], dataRow["CustomerName"], dataRow["CustomerGender"],
                        dataRow["CustomerPhoneNo"], dataRow["CustomerEmail"], dataRow["CustomerAddress"],
                        dataRow["CustomerCity"], dataRow["CustomerState"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close Sql connection
                conn.Close();
            }
        }

    }
}
