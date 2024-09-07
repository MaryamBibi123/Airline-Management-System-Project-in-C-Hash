using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectSignUp
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }


        private void welcome_Load(object sender, EventArgs e)
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

    private void button1_Click(object sender, EventArgs e)
        {
            Loginformproject login= new Loginformproject();
            this.Hide();
            login.Show();


        }
    }
}
