using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projectSignUp
{
    public partial class Loginformproject : Form
    {
        Register s = new Register();
        Flight F=new Flight();

        online_reservation O = new online_reservation();        
        public Loginformproject()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionStr);
        }
        string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\projectSignUp\projectSignUp\Airline.mdf;Integrated Security=True";
        SqlConnection connection;
        
        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked)
            {

                textBoxpass.PasswordChar = '*';
            }
            else
            {
                textBoxpass.PasswordChar = '\0';
            }
        }

        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)

        {
           
            connection.Open();
       


            string email = txtboxemail.Text;
            string password = textBoxpass.Text;

            if (email==""|| password == "")
            {
                MessageBox.Show("Kindly fill all the textBoxes properly ! ");
                
            }
           
          else  if (!s.IsEmailAlreadyRegistered(email))
            {
               DialogResult result= MessageBox.Show("Invalid Email Credentials ! Do you want to SignUp? ","Invalid Email or Passwrod " +
                    "",MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    s.Show();

                }
                else if (result==DialogResult.No)
                {

                }
                else
                {
                    txtboxemail.Clear();
                    textBoxpass.Clear();
                }
               
            }

            else
            {

              string   query = $"SELECT COUNT(1) FROM signUp WHERE Email = @Value1 AND Password = @Value2";
                using (SqlCommand command2 = new SqlCommand(query, connection))
                {
                    command2.Parameters.AddWithValue("@Value1", email);
                    command2.Parameters.AddWithValue("@Value2", password);

                    int count = (int)command2.ExecuteScalar();
                    command2.Parameters.Clear();
                    if (count > 0)
                    {

                        string queryy = "select role from signUp where Email=@value";
                     SqlCommand   command3 =new SqlCommand(queryy, connection);
                        command3.Parameters.AddWithValue("@value", email);
                        string role = command3.ExecuteScalar().ToString(); 


                        MessageBox.Show("Login successful!         ");
                        if (role == "ADMIN")
                        {
                            F.Show();
                        }
                        else if(role=="CUSTOMER")
                        {
                            O.Show();


                        }
                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password. Please try again.");
                        textBoxpass.Text = "";
                    }
                }

             
              
            }
            connection.Close();
        }
    

        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
           s.Show();
        }

        private void txtboxemail_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void Loginformproject_Load(object sender, EventArgs e)
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

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
