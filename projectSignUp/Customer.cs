using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectSignUp
{
    public partial class Customer : Form
    {
        int custId;

   
         static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\projectSignUp\projectSignUp\Airline.mdf;Integrated Security=True";
       static SqlConnection connection = new SqlConnection(connstr);
        Flight f= new Flight();
        public Customer()
        {
            InitializeComponent();
        }

       
        private void Customer_Load(object sender, EventArgs e)
        {
            masktxtname.Mask = "AAAAAAAAAAAAAAAAAAAA";
            masktxtphone.Mask = "0000000000000";


            center();
        }
       

    

    void center()
    {
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        int formWidth = this.Width;
        int formHeight = this.Height;
        int centerX = (screenWidth - formWidth) / 2;
        int centerY = (screenHeight - formHeight) / 2;

        // Set the form's position to the center of the screen
        this.StartPosition = FormStartPosition.Manual;
        this.Location = new Point(centerX, centerY);
    }

        private void btnDone_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (masktxtname.Text == "" || masktxtphone.Text == "" || comboBoxCity.Text == "")
            {
                MessageBox.Show("Kindlt fill the fields properly!", "empty field");
            }
            else
            {
                string name = masktxtname.Text.TrimStart().TrimEnd();

                string city = comboBoxCity.Text;
                int phone = int.Parse(masktxtphone.Text);

                string query = "insert into Customer values (@CustomerName,@Phone , @City); SELECT SCOPE_IDENTITY();";



                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@City", city);

                    custId = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show("YOUR SEAT IS SUCCESSFULLY BUILD!");
                    Class3.CustomerId = custId;
                    Booking b = new Booking();
                    b.Book();

                }

            }
            connection.Close();
        }
        private void lblCity_Click(object sender, EventArgs e)
        {

        }
    }
}
