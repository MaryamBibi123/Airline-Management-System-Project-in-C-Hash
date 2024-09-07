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

namespace projectSignUp
{
    public partial class Booking : Form
    {


        static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\projectSignUp\projectSignUp\Airline.mdf;Integrated Security=True";
        Dictionary<CheckBox, string> seatMappings = new Dictionary<CheckBox, string>();
        List<string> selectedSeats = new List<string>();

        int noOfSeats = 0;
        int flightId;
        public Booking()
        {
            InitializeComponent();
            setSeatMapping();
            flightId = Class3.FlightNo;
            selectedSeats = Class3.BookedSeats;
        }
        private void Booking_Load(object sender, EventArgs e)
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
    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            PrintSeatMappings();
            foreach (var kvp in seatMappings)
            {


                CheckBox checkbox = kvp.Key;
                string seatNumber = kvp.Value;

                if (checkbox.Checked)
                {

                    selectedSeats.Add(seatNumber);
                }
            }
            Class3.BookedSeats = selectedSeats;
            PrintBookedSeats(selectedSeats);
            this.Hide();
            customer.Show();

        }
        public void Book()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                PrintBookedSeats(selectedSeats);
                MessageBox.Show(""+Class3.CustomerId);
                MessageBox.Show("" + Class3.FlightNo);
                // Retrieve the selected checkboxes and their seat numbers from the dictionary
                // Store the selected seat numbers in the database
                foreach (string seatNumber in selectedSeats)

                {
                    MessageBox.Show("seat is booking ");


                    // Create a SqlCommand to insert the seat number into the table
                    string query = "INSERT INTO Booking VALUES (@CustId,@FLightId,@SeatNo)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@CustId", Class3.CustomerId);
                    command.Parameters.AddWithValue("@FLightId", flightId);
                    command.Parameters.AddWithValue("@SeatNo", seatNumber);

                    command.ExecuteNonQuery();
                    noOfSeats+=1;


              }
                updateFlightID(flightId, noOfSeats);
                conn.Close();
            }

        }

        public void updateFlightID(int flightId,int noOfSeats)
        {
            using (SqlConnection sql = new SqlConnection(connStr))

            {
                sql.Open();
                string query1 = @"select availableSeats from Flight where flightNo=@flightNo";
                SqlCommand cmd = new SqlCommand(query1, sql);
                cmd.Parameters.AddWithValue("@flightNo", flightId);
             int number= (int)cmd.ExecuteScalar();

                string query = @"update Flight set availableSeats = @newValue where flightNo=@flightId";
                SqlCommand comm1 = new SqlCommand(query, sql);
                number -= noOfSeats;

                
                if (number == 0)
                {
                    query = @"delete from Flight where flightNo =@flightId";
                    cmd= new SqlCommand(query, sql);
                    cmd.Parameters.AddWithValue("@flightId", flightId);
                    cmd.ExecuteNonQuery ();

                }else
                {
                    comm1.Parameters.AddWithValue("@newValue", number);
                    comm1.Parameters.AddWithValue("@flightId", flightId);
                    comm1.ExecuteNonQuery();
                }

               

                sql.Close();
            }
           
        }

        private void checkBox2A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1A_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5D_CheckedChanged(object sender, EventArgs e)
        {

        }
        void DisableBookedSeats()
        {
            List<string> bookedSeats = RetrieveBookedSeatsForFlight(flightId);

            foreach (var kvp in seatMappings)
            {
                CheckBox checkbox = kvp.Key;
                string seatNumber = kvp.Value;

                if (bookedSeats.Contains(seatNumber))
                {

                    Label l = new Label();
                    l.Location = checkbox.Location;
                    l.Text = "✔️";
                    this.Controls.Add(l);


                    checkbox.Enabled = false;//

                    l.Visible = true;

                }
            }
        }
        void setSeatMapping()
        {
            int rowCount = 5; // Number of rows
            int columnCount = 4; // Number of columns

            char[] rowStartChars = { 'A', 'B', 'C', 'D' }; // Starting characters for seat rows

            for (int row = 1; row <= rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    char seatRow = rowStartChars[col];
                    string seatNumber = $"{row}{seatRow}";

                    // Find the checkbox by name
                    string checkboxName = $"checkBox{seatNumber}";
                    CheckBox checkbox = this.Controls.Find(checkboxName, true).FirstOrDefault() as CheckBox;

                    if (checkbox != null)
                    {

                        seatMappings.Add(checkbox, seatNumber);
                    }


                }
            }
            DisableBookedSeats();

        }
        private List<string> RetrieveBookedSeatsForFlight(int flightID)
        {
            List<string> bookedSeats = new List<string>();

            // Assuming you have a database connection established
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                // Query to retrieve the booked seats for the specified flight
                string query = "SELECT SeatNo FROM Booking WHERE FlightID = @FlightID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the FlightID parameter
                    command.Parameters.AddWithValue("@FlightID", flightID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve the SeatNumber from the result set
                            string seatNumber = reader.GetString(reader.GetOrdinal("SeatNo"));

                            bookedSeats.Add(seatNumber);
                        }
                    }
                }
            }
            return bookedSeats;
        }
        void PrintSeatMappings()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in seatMappings)
            {
                CheckBox checkbox = kvp.Key;
                string seatNumber = kvp.Value;

                sb.AppendLine($"Checkbox: {checkbox.Name}, Seat Number: {seatNumber}");
            }

            MessageBox.Show(sb.ToString(), "Seat Mapping");
        }
        void PrintBookedSeats(List<string> bookedSeats)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string seatNumber in bookedSeats)
            {
                sb.AppendLine($"Seat Number: {seatNumber}");
            }

            MessageBox.Show(sb.ToString(), "Booked Seats");
        }
    }
    
}
