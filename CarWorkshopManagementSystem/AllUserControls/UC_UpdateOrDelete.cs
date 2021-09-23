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
    public partial class UC_UpdateOrDelete : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OJFKR3C\SQLEXPRESS;Initial Catalog=CarWorkshopManagementSystem;Integrated Security=True");

        public UC_UpdateOrDelete()
        {
            InitializeComponent();
        }

        private void UC_UpdateOrDelete_Load(object sender, EventArgs e)
        {
            DisplayTasksData();
        }
        private void DisplayTasksData()
        {
            try
            {
                //Open Sql COnnection
                conn.Open();

                string query = "SELECT c.CarID,c.CarModel,c.CarNumber,c.CarType,c.CarColor,c.CarProblem,c.CarStatus,c.CarAssignDate,c.CarReleaseDate, cu.CustomerID,cu.CustomerFirstName,cu.CustomerLastName,cu.CustomerGender,cu.CustomerPhoneNo,cu.CustomerEmail,cu.CustomerAddress,cu.CustomerCity,cu.CustomerState FROM Tasks AS t FULL OUTER JOIN CarsData AS c ON t.CarID = c.CarID FULL OUTER JOIN CustomersData AS cu ON t.CustomerID = cu.CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvUpdateDelete.Rows.Clear();

                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    dgvUpdateDelete.Rows.Add(sn, dataRow["CarID"], dataRow["CarModel"], dataRow["CarNumber"], dataRow["CarType"], dataRow["CarColor"], dataRow["CarProblem"], dataRow["CarStatus"], dataRow["CarAssignDate"], dataRow["CarReleaseDate"], dataRow["CustomerID"], dataRow["CustomerFirstName"], dataRow["CustomerLastName"], dataRow["CustomerGender"], dataRow["CustomerPhoneNo"], dataRow["CustomerEmail"], dataRow["CustomerAddress"], dataRow["CustomerCity"], dataRow["CustomerState"], "Select");
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

        int Car_ID;
        private void dgvUpdateDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUpdateDelete.Columns["RecordAction"].Index)
            {
                //Car_ID = Convert.ToInt32(dgvUpdateDelete.CurrentRow.Cells["carIDd"].Value.ToString());
                Car_ID = Convert.ToInt32(dgvUpdateDelete.CurrentRow.Cells["carIDd"]);
                string Car_IDd = Car_ID.ToString();
                string Car_Model = dgvUpdateDelete.CurrentRow.Cells["carModel"].Value.ToString();
                string Car_Number = dgvUpdateDelete.CurrentRow.Cells["carNumber"].Value.ToString();
                string Car_Type = dgvUpdateDelete.CurrentRow.Cells["carType"].Value.ToString();
                string Car_Color = dgvUpdateDelete.CurrentRow.Cells["carColor"].Value.ToString();
                string Car_Problem = dgvUpdateDelete.CurrentRow.Cells["carProblem"].Value.ToString();
                string Car_Status = dgvUpdateDelete.CurrentRow.Cells["carStatus"].Value.ToString();
                string Car_AssignDate = dgvUpdateDelete.CurrentRow.Cells["carAssignDate"].Value.ToString();
                string Car_ReleaseDate = dgvUpdateDelete.CurrentRow.Cells["carReleaseDate"].Value.ToString();
                string Customer_ID = dgvUpdateDelete.CurrentRow.Cells["cID"].Value.ToString();
                string Customer_FirstName = dgvUpdateDelete.CurrentRow.Cells["cFirstName"].Value.ToString();
                string Customer_LastName = dgvUpdateDelete.CurrentRow.Cells["cLastName"].Value.ToString();
                string Customer_Gender = dgvUpdateDelete.CurrentRow.Cells["cGender"].Value.ToString();
                string Customer_PhoneNo = dgvUpdateDelete.CurrentRow.Cells["cPhoneNo"].Value.ToString();
                string Customer_Email = dgvUpdateDelete.CurrentRow.Cells["cEmail"].Value.ToString();
                string Customer_Address = dgvUpdateDelete.CurrentRow.Cells["cAddress"].Value.ToString();
                string Customer_City = dgvUpdateDelete.CurrentRow.Cells["cCity"].Value.ToString();
                string Customer_State = dgvUpdateDelete.CurrentRow.Cells["cState"].Value.ToString();

                txbCuID.Text = Customer_ID;
                txbCuFirstName.Text = Customer_FirstName;
                txbCuLastName.Text = Customer_LastName;
                txbCuGender.Text = Customer_Gender;
                txbCuPhoneNo.Text = Customer_PhoneNo;
                txbCuEmail.Text = Customer_Email;
                txbCuAddress.Text = Customer_Address;
                txbCuCity.Text = Customer_City;
                txbCuState.Text = Customer_State;

                txbCarID.Text = Car_IDd; 
                txbCarModel.Text = Car_Model;
                txbCarNumber.Text = Car_Number;
                txbCarType.Text = Car_Type;
                txbCarColor.Text = Car_Color;
                txbCarProblem.Text = Car_Problem;
                txbCarAssignDate.Text = Car_AssignDate;
                txbCarReleaseDate.Text = Car_ReleaseDate;
                txbCarStatus.Text = Car_Status;

            }
        }
        private void kryptonBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Car_ID != 0)
                {
                    //Open Sql Connection
                    conn.Open();

                    string c_ID = txbCuID.Text;
                    string c_FirstName = txbCuFirstName.Text;
                    string c_LastName = txbCuLastName.Text;
                    string c_Gender = txbCuGender.Text;
                    string c_PhoneNo = txbCuPhoneNo.Text;
                    string c_Email = txbCuEmail.Text;
                    string c_Address = txbCuAddress.Text;
                    string c_City = txbCuCity.Text;
                    string c_State = txbCuState.Text;

                    string car_ID = txbCarID.Text;
                    string car_Model = txbCarModel.Text;
                    string car_Number = txbCarNumber.Text;
                    string car_Type = txbCarType.Text;
                    string car_Color = txbCarColor.Text;
                    string car_Problem = txbCarProblem.Text;
                    string car_Status = txbCarStatus.Text;
                    string car_AssignDate = txbCarAssignDate.Text;
                    string car_ReleaseDate = txbCarReleaseDate.Text;
                    

                    //save data to database

                    //passing parameter method
                    String queryUpdateCustomer = "update CustomersData set CustomerFirstName=@parameter_FirstName, CustomerLastName=@parameter_LastName" +
                        "CustomerGender = @parameter_Gender,CustomerPhoneNo = @parameter_PhoneNo, CustomerEmail = @parameter_Email, CustomerAddress = @parameter_Address," +
                        "CustomerCity = @parameter_City, CustomerState = @parameter_State where CustomerID=@parameter_cuID";
                    SqlCommand cmd = new SqlCommand(queryUpdateCustomer, conn);

                    cmd.Parameters.AddWithValue("@parameter_cuID", c_ID);
                    cmd.Parameters.AddWithValue("@parameter_FirstName", c_FirstName);
                    cmd.Parameters.AddWithValue("@parameter_LastName", c_LastName);
                    cmd.Parameters.AddWithValue("@parameter_Gender", c_Gender);
                    cmd.Parameters.AddWithValue("@parameter_PhoneNo", c_PhoneNo);
                    cmd.Parameters.AddWithValue("@parameter_Email", c_Email);
                    cmd.Parameters.AddWithValue("@parameter_Address", c_Address);
                    cmd.Parameters.AddWithValue("@parameter_City", c_City);
                    cmd.Parameters.AddWithValue("@parameter_State", c_State);

                    String queryUpdateCar = "update CarsData set CarModel=@parameter_Model, CarNumber=@parameter_Number," +
                        "CarType=@parameter_Type, CarColor=@parameter_Color, CarProblem=@parameter_Problem, CarStatus=@parameter_Status," +
                        "CarAssignDate=@parameter_Assigndate, CarReleaseDate=@parameter_Releasedate where CarID=@parameter_carID";
                    SqlCommand cmd1 = new SqlCommand(queryUpdateCar, conn);

                    cmd1.Parameters.AddWithValue("@parameter_carID", car_ID);
                    cmd1.Parameters.AddWithValue("@parameter_Model", car_Model);
                    cmd1.Parameters.AddWithValue("@parameter_Number", car_Number);
                    cmd1.Parameters.AddWithValue("@parameter_Type", car_Type);
                    cmd1.Parameters.AddWithValue("@parameter_Color", car_Color);
                    cmd1.Parameters.AddWithValue("@parameter_Problem", car_Problem);
                    cmd1.Parameters.AddWithValue("@parameter_Status", car_Status);
                    cmd1.Parameters.AddWithValue("@parameter_AssignDate", car_AssignDate);
                    cmd1.Parameters.AddWithValue("@parameter_ReleaseDate", car_ReleaseDate);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfully");
                    //txtbName.Text = "";
                    //txtbAddress.Text = "";
                    //student_ID = 0;
                    //UC_AddCustomer.ClearCustomersText();

                    /*
                    Alternative Way (Direct/normal query method)

                    string query = "Insert into student_details (Name,Address) values ("+st_name+","+st_address+")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                    txtbName.Text = "";
                    txtbAddress.Text = "";
                    */
                }
                else
                {
                    MessageBox.Show("Please edit data before updating");
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
            DisplayTasksData();
            ClearCarsText();
            ClearCustomersText();
            
        }
        private void kryptonBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Car_ID != 0)
                {
                    conn.Open();

                    String queryDeleteCustomerRecord = "delete from CustomersData where CustomerID = txbCuID.Text";
                    String queryDeleteCarRecord = "delete form CarsData where CarID = txbCarID.Text";
                }
                else
                {
                    MessageBox.Show("No data selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            DisplayTasksData();
            ClearCarsText();
            ClearCustomersText();
        }
        private void UC_UpdateOrDelete_Leave(object sender, EventArgs e)
        {
            ClearCarsText();
            ClearCustomersText();
        }
        public void ClearCustomersText()
        {
            txbCuID.Text = "";
            txbCuFirstName.Text = "";
            txbCuLastName.Text = "";
            txbCuGender.Text = "";
            txbCuPhoneNo.Text = "";
            txbCuEmail.Text = "";
            txbCuAddress.Text = "";
            txbCuCity.Text = "";
            txbCuState.Text = "";
        }
        public void ClearCarsText()
        {
            txbCarID.Text = "";
            txbCarModel.Text = "";
            txbCarNumber.Text = "";
            txbCarType.Text = "";
            txbCarColor.Text = "";
            txbCarProblem.Text = "";
            txbCarStatus.Text = "";
            txbCarAssignDate.Text = "";
            txbCarReleaseDate.Text = "";
        }

    }
}
