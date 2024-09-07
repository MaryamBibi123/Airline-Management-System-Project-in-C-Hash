using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectSignUp
{
    public partial class online_reservation : Form
    {

        static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\projectSignUp\projectSignUp\Airline.mdf;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connstr);
        Boolean search = false;
        DataTable dt=new DataTable();
        AvailableFlights av = new AvailableFlights(2);

        public online_reservation()
        {
            InitializeComponent();
            rdbtnOneway.Enabled = true;

        }
        private void lblarrivalcity_Click(object sender, EventArgs e)
        {

        }
        private void lbljourneytype_Click(object sender, EventArgs e)
        {

        }

        private void lbldeparcity_Click(object sender, EventArgs e)
        {

        }

        private void lbldepardate_Click(object sender, EventArgs e)
        {

        }

        private void lblonlineRes_Click(object sender, EventArgs e)
        {


        }



        private void txtboxDeparCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxArrivCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxdepardate_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtboxchild_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtboxyoung_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }




        private void online_reservation_Load(object sender, EventArgs e)
        {
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

    private void rdbtnOneway_CheckedChanged(object sender, EventArgs e)

        {
            if (cmboboxdeparCity.SelectedIndex != -1 && cmboboxArrivCity.SelectedIndex != -1 && cmboboxdeparCity.SelectedItem.ToString() != cmboboxArrivCity.SelectedItem.ToString())
            {
                // Set the color of the control to system color
                cmboboxdeparCity.BackColor = SystemColors.Window;
                cmboboxArrivCity.BackColor = SystemColors.Window;
            }

        }




        
        private void cmboboxArrivCity_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        private void cmboboxdeparCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnsearchflight_Click(object sender, EventArgs e)
        {
            string source = cmboboxdeparCity.Text;
            string destination = cmboboxArrivCity.Text;
           
           
            if (source == "" || destination == "")
            {
                MessageBox.Show("Fill the fields properly!", "Empty field");

            }
            else
            {
                dt = RetrieveFilteredFlightsFromDatabase(source, destination);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No flights available today!");
                }
                else
                {
                    if (source != destination)
                    {

                        ShowFlightsForm(dt);

                    }
                    else
                    {
                        MessageBox.Show("The flights are only one way! please select \n different " +
                            "Arrival and Departure Cities! ", "Invalid Flight Route ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                
            }

        }

      



        private DataTable RetrieveFilteredFlightsFromDatabase(string source, string destination)
        {
            DataTable filteredFT = new DataTable();

            connection.Open();
            string query = "SELECT flightNo, flight_Name,maxSeats,availableSeats, Source, Destination FROM Flight WHERE Source = @Source AND Destination = @Destination";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Source", source);
                command.Parameters.AddWithValue("@Destination", destination);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    filteredFT.Load(reader);
                }
            }
            connection.Close();

            return filteredFT;
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
        private void ShowFlightsForm(DataTable flightsTable)
        {
            AvailableFlights flightsForm = new AvailableFlights(2);
            flightsForm.DisplayFlightsInDataGridView(flightsTable);
            this.Hide();
            flightsForm.Show();
            
        }

        private void btnsearchall_Click(object sender, EventArgs e)
        {
            dt= RetrieveAllFlightsFromDatabase();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No flights available!");
            }
            else { 
            ShowFlightsForm(dt);}
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new welcome().Show();
        }
    }
}

