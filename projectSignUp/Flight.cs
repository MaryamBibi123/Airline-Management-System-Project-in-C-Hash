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
using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projectSignUp
{
    public partial class Flight : Form
    {
        static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\projectSignUp\projectSignUp\Airline.mdf;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connstr);
        DataTable data = new DataTable();


        public Flight()
        {
            InitializeComponent();
        }


        private void FlightNolbl_Click(object sender, EventArgs e)
        {

        }

        private void airlinelbl_Click(object sender, EventArgs e)
        {

        }

        private void maxseatlbl_Click(object sender, EventArgs e)
        {

        }

        public void flightIdtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void airlinetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        public Boolean FlightsExists(int flight)
        {
            int count;
            string query = "select count(1) from Flight where flightNo=@flightNo";

            using (SqlCommand sq = new SqlCommand(query, connection))
            {
                sq.Parameters.AddWithValue("@flightNo", flight);

                count = (int)sq.ExecuteScalar();

                return count > 0;


            }

        }
    

    

        private void btnAddflight_Click(object sender, EventArgs e)
        {
            btnCancelflight.Visible =
                false;
            connection.Open();
            try
            {
              

                string airline = cmboboxAirline.Text;
                int flightId;
                
                int maxseats = 20;
                string destination = cmboDestin.Text;
                string source = cmboSource.Text;

                if (airline != "" && flightIdtxtbox.Text != "" && maxseats.ToString() != ""&& source!=""&& destination!="")
                {
                    flightId = int.Parse(flightIdtxtbox.Text);
                    if (FlightsExists(flightId))
                    {
                      
                        MessageBox.Show("This flight is already added !", "FlightId Exists ", MessageBoxButtons.OK);
                        flightIdtxtbox.Clear();
                        flightIdtxtbox.Focus();
                       
                    }
                    else
                    {
                        
                        string query = "insert into Flight values " +
                            "(@flightNo,@flight_name,@maxSeats,@availableSeats,@Source,@Destination)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@flightNo", flightId);

                            command.Parameters.AddWithValue("@flight_name", airline);

                            command.Parameters.AddWithValue("@maxSeats", maxseats);
                            command.Parameters.AddWithValue("@availableSeats", maxseats);
                            command.Parameters.AddWithValue("@Destination", destination);
                            command.Parameters.AddWithValue("@Source", source);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Flight is Successfully Added!","Flight Added" +
                                "",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                }

                else
                {

                    MessageBox.Show("Kindly Fill All the boxes prroperly ! ",
                        "Input Error! ❌" ,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning
                        );
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (flightIdtxtbox.Text != "") {
                int flightId = int.Parse(flightIdtxtbox.Text);
                if (FlightsExists(flightId))
                {
                    string query = @"DELETE FROM Flight WHERE flightNo=@flightNo";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@flightNo", flightId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("The flight is Removed !");
                    string query2 = @"delete from Booking where FlightId=@FlightId";
                    SqlCommand command2 = new SqlCommand( query2, connection);
                    command2.Parameters.AddWithValue("@flightId", flightId);

                    command2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("The flight doesn't exist! ");
                    flightIdtxtbox.Focus();
                }

               
            }
            else
            {
                MessageBox.Show("Please Enter the  flight Id! ", "Invalid input");
                flightIdtxtbox.Focus();
            }
           
            connection.Close();
                }

        private void Flight_Load(object sender, EventArgs e)
        {

            flightIdtxtbox.Mask = "000000000000000";
            FlightNolbl.Visible = false;
            flightIdtxtbox.Visible = false;
            airlinelbl.Visible = false;
            cmboboxAirline.Visible = false;
           
            btnAddflight.Visible = false;
            btnCancelflight.Visible = false;
            cmboDestin.Visible = false;
            cmboSource.Visible = false;
            DestinationLbl.Visible = false;
            Sourcelbl.Visible = false;
            cmboDestin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboSource.DropDownStyle = ComboBoxStyle.DropDownList;

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


    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        private void picBoxAdd_Click(object sender, EventArgs e)
        {
            picBoxAdd.Visible = false;
            picBoxDelete.Visible = false;
            FlightNolbl.Visible = true;
            flightIdtxtbox.Visible = true;
            airlinelbl.Visible = true;
            cmboboxAirline.Visible = true;
           
            btnAddflight.Visible = true;
            DestinationLbl.Visible = true;
            Sourcelbl.Visible = true;
            cmboDestin.Visible = true;
            cmboSource.Visible=true;

        }

       

        private void picBoxDelete_Click(object sender, EventArgs e)
        {
            picBoxAdd.Visible = false;
            picBoxDelete.Visible = false;
            FlightNolbl.Visible = true;
            flightIdtxtbox.Visible = true;
            btnCancelflight.Visible = true;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void picBoxAdd_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cmboDestin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DestinationLbl_Click(object sender, EventArgs e)
        {

        }

        private void picBoxShowFlight_Click(object sender, EventArgs e)
        {

            data= RetrieveAllFlightsFromDatabase();

            AvailableFlights available = new AvailableFlights(1);
            available.DisplayFlightsInDataGridView(data);
            this.Hide();
            available.Show();


        }
        private DataTable RetrieveAllFlightsFromDatabase()
        {

            string query = "SELECT * FROM Flight";
            SqlCommand command = new SqlCommand(query, connection);

            DataTable flightsTable = new DataTable();

            connection.Open();
            flightsTable.Load(command.ExecuteReader());
            connection.Close();

            return flightsTable;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
          new  Flight().Show();
        }

        private void flightIdtxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmboboxAirline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new welcome().Show();
        }
    }
}
