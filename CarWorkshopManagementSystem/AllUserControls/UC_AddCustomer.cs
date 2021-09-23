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
    public partial class UC_AddCustomer : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OJFKR3C\SQLEXPRESS;Initial Catalog=CarWorkshopManagementSystem;Integrated Security=True");

        public UC_AddCustomer()
        {
            InitializeComponent();
        }

        int taskCarId;
        int taskCustomerId;
        private void kryptonBtnAdd_Click(object sender, EventArgs e)
        {
            if (Hello)
            {
                MessageBox.Show("hello");
            }
            else
            {
                MessageBox.Show("Oh no!");
            }
            try
            {
                //Open Sql Connection
                conn.Open();

                string cFirstName = txbCuFirstName.Text;
                string cLastName = txbCuLastName.Text;
                string cAddress = txbCuAddress.Text;
                string cCity = txbCuCity.Text;
                string cState = cbCuState.Text;
                string cPhoneNo = txbCuPhoneNo.Text;
                string cEmail = txbCuEmail.Text;
                string cGender = txbCuGender.Text;

                string carModel = txbCarModel.Text;
                string carNumber = txbCarNumber.Text;
                string carType = txbCarType.Text;
                string carColor = txbCarColor.Text;
                string carProblem = txbCarProblem.Text;
                string carAssignDate = txbCarAssignDate.Text;
                string carReleaseDate = txbCarReleaseDate.Text;
                string carStatus = txbCarStatus.Text;

                String queryCustomerAdd = "Insert into CustomersData (CustomerFirstName, CustomerLastName," +
                    "CustomerAddress,CustomerCity,CustomerState,CustomerPhoneNo,CustomerEmail," +
                    "CustomerGender) values (@parameter_FirstName,@parameter_LastName,@parameter_Address," +
                    "@parameter_City,@parameter_State,@parameter_PhoneNo,@parameter_Email,@parameter_Gender)";

                String queryCarAdd = "Insert into CarsData (CarModel, CarNumber, CarType, CarColor, CarProblem, CarAssignDate, " +
                    "CarReleaseDate, CarStatus) values(@parameter_Model, @parameter_Number, @parameter_Type, " +
                    "@parameter_Color, @parameter_Problem, @parameter_AssignDate, @parameter_ReleaseDate, @parameter_Status)";

                SqlCommand cmd = new SqlCommand(queryCustomerAdd, conn);
                cmd.Parameters.AddWithValue("@parameter_FirstName", cFirstName);
                cmd.Parameters.AddWithValue("@parameter_LastName", cLastName);
                cmd.Parameters.AddWithValue("@parameter_Address", cAddress);
                cmd.Parameters.AddWithValue("@parameter_City", cCity);
                cmd.Parameters.AddWithValue("@parameter_State", cState);
                cmd.Parameters.AddWithValue("@parameter_PhoneNo", cPhoneNo);
                cmd.Parameters.AddWithValue("@parameter_Email", cEmail);
                cmd.Parameters.AddWithValue("@parameter_Gender", cGender);

                SqlCommand cmd1 = new SqlCommand(queryCarAdd, conn);
                cmd1.Parameters.AddWithValue("@parameter_Model", carModel);
                cmd1.Parameters.AddWithValue("@parameter_Number", carNumber);
                cmd1.Parameters.AddWithValue("@parameter_Type", carType);
                cmd1.Parameters.AddWithValue("@parameter_Color", carColor);
                cmd1.Parameters.AddWithValue("@parameter_Problem", carProblem);
                cmd1.Parameters.AddWithValue("@parameter_AssignDate", carAssignDate);
                cmd1.Parameters.AddWithValue("@parameter_ReleaseDate", carReleaseDate);
                cmd1.Parameters.AddWithValue("@parameter_Status", carStatus);

                ////For Photo: save entire path
                //cmd.Parameters.AddWithValue("@parameter_Photo_Path", path);
                ////For Photo : save file name only
                ////cmd.Parameters.AddWithValue("@parameter_Photo_Path", file_name);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                String queryFetchCustomerID = "SELECT CustomerID FROM CustomersData WHERE CustomerID=(SELECT MAX(CustomerID) FROM CustomersData)";
                SqlCommand cmd2 = new SqlCommand(queryFetchCustomerID, conn);
                using (SqlDataReader sdr = cmd2.ExecuteReader())
                {
                    sdr.Read();
                    //taskCarId = sdr["CustomerID"].ToString();
                    taskCustomerId = Convert.ToInt32(sdr["CustomerID"]);
                }
                String queryFetchCarID = "SELECT CarID FROM CarsData WHERE CarID=(SELECT MAX(CarID) FROM CarsData)";
                SqlCommand cmd3 = new SqlCommand(queryFetchCarID, conn);
                using (SqlDataReader sdr = cmd3.ExecuteReader())
                {
                    sdr.Read();
                    taskCarId = Convert.ToInt32(sdr["CarID"]);

                }

                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                String queryTaskAdd = "insert into Tasks (CustomerID, CarID) values ("+taskCustomerId+","+taskCarId+")";
                SqlCommand cmd4 = new SqlCommand(queryTaskAdd, conn);
                cmd4.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");

                ClearCustomersText();
                ClearCarsText();

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

            // DisplayData();
        }
        public void ClearCustomersText()
        {
            txbCuFirstName.Text = "";
            txbCuLastName.Text = "";
            txbCuAddress.Text = "";
            txbCuCity.Text = "";
            cbCuState.Text = "";
            txbCuPhoneNo.Text = "";
            txbCuEmail.Text = "";
            txbCuGender.Text = "";
        }

        public void ClearCarsText()
        {
            txbCarModel.Text = "";
            txbCarNumber.Text = "";
            txbCarType.Text = "";
            txbCarColor.Text = "";
            txbCarProblem.Text = "";
            txbCarAssignDate.Text = "";
            txbCarReleaseDate.Text = "";
            txbCarStatus.Text = "";
        }
        private void UC_AddCustomer_Leave(object sender, EventArgs e)
        {
            ClearCustomersText();
            ClearCarsText();
        }

        bool Hello = true;
        private bool IsTextBoxEmpty()
        {
            //if (string.IsNullOrEmpty(txbCuFirstName.Text) && string.IsNullOrEmpty(txbCuLastName.Text) && string.IsNullOrEmpty(txbCuGender.Text)
            //     && string.IsNullOrEmpty(txbCuPhoneNo.Text) && string.IsNullOrEmpty(txbCuEmail.Text) && string.IsNullOrEmpty(txbCuAddress.Text)
            //     && string.IsNullOrEmpty(txbCuCity.Text) && string.IsNullOrEmpty(cbCuState.Text) && string.IsNullOrEmpty(txbCarModel.Text)
            //     && string.IsNullOrEmpty(txbCarNumber.Text) && string.IsNullOrEmpty(txbCarType.Text) && string.IsNullOrEmpty(txbCarColor.Text)
            //     && string.IsNullOrEmpty(txbCarStatus.Text) && string.IsNullOrEmpty(txbCarStatus.Text) && string.IsNullOrEmpty(txbCarAssignDate.Text))
            if(string.IsNullOrEmpty(txbCuFirstName.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
