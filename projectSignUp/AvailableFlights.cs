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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectSignUp
{
     partial class AvailableFlights : Form
    {
        Booking b;
        DataTable flights;
     
        int flightNo;
       static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\projectSignUp\projectSignUp\Airline.mdf;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connstr);
       
        public AvailableFlights(int check)
        {
            flights = new DataTable();
            InitializeComponent();
            if (check == 1)
            {
                EnableControlsForAdmin();
            }
            else if (check == 2)
            {
                EnableControlsForCustomer();
            }
           
        }


       
     
       
        public  void DisplayFlightsInDataGridView(DataTable flightstable)
        {
            dataGridView1.DataSource = flightstable ;
            dataGridView1.ReadOnly = true;

            flights = flightstable;

        }
        private void AvailableFlights_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle=ComboBoxStyle.DropDownList;
           
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

   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void EnableControlsForCustomer()
        {
            btbback.Visible = false;
            comboBox1.Visible = false;
            lblselectflight.Visible = false;
            btnBookFlight.Visible = false;  
        }

        public void EnableControlsForAdmin()
        {

            comboBox1.Visible = false;
            btnBookFlight.Visible = false;
            btnselectFlight.Visible = false;
            lblselectflight.Visible=false;

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

      
        private void btnselectFlight_Click(object sender, EventArgs e)
        {
            List<int> values = new List<int>();


            foreach (DataRow row in flights.Rows)
            {
                int value = Convert.ToInt32(row["flightNo"]);
                values.Add(value);

               
                
            }
            comboBox1.DataSource = values;
            comboBox1.Visible = true;
            lblselectflight.Visible = true;

            btnBookFlight.Visible = true;
/*
          
*/
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
           
            flightNo = (int)comboBox1.SelectedItem;
            MessageBox.Show(""+flightNo);
          Class3.FlightNo = flightNo;
            b = new Booking();
            this.Hide();
            b.Show();

        }

        private void btbback_Click(object sender, EventArgs e)
        {
            this.Hide();
           Flight flight= new Flight();
            flight.Show();
        }
    }
}

