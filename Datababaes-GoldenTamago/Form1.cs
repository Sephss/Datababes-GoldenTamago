using Datababaes_GoldenTamago.Forms;
using Datababaes_GoldenTamago.Services;

namespace Datababaes_GoldenTamago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            this.FormBorderStyle = FormBorderStyle.None;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                const int CS_NOCLOSE = 0x200; // Windows API constant to disable Close button
                cp.ClassStyle |= CS_NOCLOSE;  // Apply the style
                return cp;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            string username = textBox1.Text;
            string password = textBox2.Text;

            Auth auth = new Auth();
            bool isUserCredentialCorrect = auth.logInUser(username, password);

            if (isUserCredentialCorrect)
            {
                home.checkUserRole(username);
                MessageBox.Show("Login Successful");
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed, Invalid username or password");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
