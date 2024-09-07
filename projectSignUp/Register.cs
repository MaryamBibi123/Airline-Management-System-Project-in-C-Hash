using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectSignUp
{
    public partial class Register : Form

    {

        Loginformproject login;
        static string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\projectSignUp\projectSignUp\Airline.mdf;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connectionStr);

        public Register()
        {

            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
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
    private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void textboxemail_TextChanged(object sender, EventArgs e)
        {
            string email = textboxemail.Text;
            if (IsEmailAlreadyRegistered(email))
            {
              DialogResult result=MessageBox.Show("THIS EMAIL IS ALREADY REGISTERED\nCLICK YES TO LOGIN !" ,"Email Exists",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    login.Show();

                }
                else if (result == DialogResult.No)
                {
                    textboxemail.Clear();
                }
                else
                {
                    textboxemail.Clear();
                    textBoxpass.Clear();
                    
                }
            }
        }

        private void constraintlblpass_Click(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {
            string labelofconstraint = constraintlblpass.Text;
            string pass = textBoxpass.Text;
            if (!IsPasswordValid(pass))
            {

                constraintlblpass.Text = "Enter a valid password according to the constraint!";
                confirmpasslabel.Text = "";
                textBoxconfirmpass.Enabled = false;


            }
            else
            {
                constraintlblpass.Text = labelofconstraint;
                textBoxconfirmpass.Enabled = true;

            }

        }

        private void lblconfirmpass_Click(object sender, EventArgs e)
        {

        }

        private void textBoxconfirmpass_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxpass.Text;
            string confirmPassword = textBoxconfirmpass.Text;

            // Compare the two strings
            if (password != "" && confirmPassword == password)
            {
                // If the strings match, set the label text to "Passwords match" and color to green
                confirmpasslabel.Text = "Passwords match";
                confirmpasslabel.ForeColor = Color.Green;
            }
            else
            {
                // If the strings don't match, set the label text to "Passwords do not match" and color to red
                confirmpasslabel.Text = "Passwords do not match";
                confirmpasslabel.ForeColor = Color.Red;
                textboxemail_TextChanged(sender, e);
            }
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            String s = textboxemail.Text;


            if (textboxemail.Text == "" || textBoxpass.Text == "" || textBoxconfirmpass.Text == "")
            {
                MessageBox.Show("KINDLY FILL ALL BOX PROPERLY !");
            }
            else if(cmboboxrole.Text=="") {
                MessageBox.Show("You have not selected any role yet!");
             
            }
            else
            {

                if (IsValidEmail(textboxemail.Text))// checking the validation of the email

                {
                    string username = textboxemail.Text;
                    string pass = textBoxpass.Text;
                    string confirmpass = textBoxconfirmpass.Text;
                    SaveUserInformation(username, pass);
                    this.Hide();
                    MessageBox.Show("YOU ARE SUCCESSFULLY REGISTERED! ","REGISTRATION");

                    login = new Loginformproject();
                    login.ShowDialog();

                }
                else
                {
                    MessageBox.Show($"The email address" + s + " is invalid."
                                    );
                    textboxemail.Focus();
                    //  buttonregister_Click(sender, e);
                }
            }
        }

        private void btncacel_Click(object sender, EventArgs e)
        {

            textboxemail.Text = "";
            textBoxpass.Text = "";
            textBoxconfirmpass.Text = "";
        }
        public static bool IsValidEmail(string email)
        {
            // Check if email starts with a number
            if (Char.IsDigit(email[0]))
            {
                return false;
            }

            // Validate email pattern using regular expression
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                return false;
            }

            // Check if domain contains any numbers
            string domain = email.Split('@')[1];
            if (domain.Any(char.IsDigit))
            {
                return false;
            }

            // Split domain labels by period and validate each label
            string[] domainLabels = domain.Split('.');
            if (domainLabels.Length < 2)
            {
                return false;
            }

            // Check if last domain label is a valid TLD
            string lastLabel = domainLabels.Last();
            string[] validTLDs = { "com", "org", "net", "edu", "gov" };
            if (validTLDs.Contains(lastLabel))
            {
                return true;
            }

            // Check if last domain label is a valid country code TLD
            string[] validCountryTLDs = { "us", "uk", "au", "ca", "in", "pk", "cn", "jp", "de", "fr" };
            if (validCountryTLDs.Contains(lastLabel))
            {
                // Check if second-to-last domain label is a valid institute or organization label
                if (domainLabels.Length < 3)
                {
                    return false;
                }
                string secondLastLabel = domainLabels[domainLabels.Length - 2];
                string[] validOrgLabels = { "edu", "ac", "gov", "org", "com", "net" };
                if (validOrgLabels.Contains(secondLastLabel))
                {
                    return true;
                }
            }

            // Domain is invalid
            return false;
        }

        private void confirmpasslabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxshowpass.Checked)
            {

                textBoxpass.PasswordChar = '*';
                textBoxconfirmpass.PasswordChar = '*';
            }
            else
            {
                textBoxpass.PasswordChar = '\0';
                textBoxconfirmpass.PasswordChar = '\0';
            }
        }
        private void SaveUserInformation(string email, string password)
        {
            try
            {
                connection.Open();
                string query = "insert into signUp values (@Email,@Password,@role)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("Email", email);
                    command.Parameters.AddWithValue("Password", password);
                    command.Parameters.AddWithValue("role", cmboboxrole.Text);
                    command.ExecuteNonQuery();

                }
                connection.Close();//
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public static bool IsValidEmaill(string email)
        {
            // Check if email is in correct format
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool isMatch = Regex.IsMatch(email, pattern);

            if (!isMatch) return false;

            // Check if domain is valid
            string[] domainParts = email.Split('@');
            string domain = domainParts[1];
            try
            {
                System.Net.Dns.GetHostEntry(domain);
                return true;
            }
            catch (System.Net.Sockets.SocketException)
            {
                return false;
            }
        }
        public bool IsPasswordValid(string password)
        {
            // Check length of password
            if (password.Length < 5 || password.Length > 10)
            {
                return false;
            }

            // Check if password starts with a number
            if (char.IsDigit(password[0]))
            {
                return false;
            }

            // Check if password contains only letters, numbers, and underscores
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c) && c != '_' && c != '@')
                {
                    return false;
                }
            }

            // If we've reached this point, the password is valid
            return true;
        }


        public  bool IsEmailAlreadyRegistered(string email)
        {
            connection.Open();
            string query = $"SELECT COUNT(1) FROM signUp WHERE Email = @Value";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Value", email);

                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        private void lBLSIGNUP_Click(object sender, EventArgs e)
        {

        }

        private void cmboboxrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new welcome().Show();
        }
    }

}
