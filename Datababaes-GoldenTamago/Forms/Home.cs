using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datababaes_GoldenTamago.Forms
{
    public partial class Home : Form
    {
        private Label activeLabel;
        public Home()
        {
            InitializeComponent();
            // Remove the borders
            this.FormBorderStyle = FormBorderStyle.None;

            // by default the color of the home is red
            activeLabel = label1;
            label1.BackColor = Color.Red;

            //apply the hover effects to nav links
            label1.MouseEnter += lbl_MouseEnter;
            label1.MouseLeave += lbl_MouseLeave;
            label1.Click += lblNav_Click;

            inventoryNav.MouseEnter += lbl_MouseEnter;
            inventoryNav.MouseLeave += lbl_MouseLeave;
            inventoryNav.Click += lblNav_Click;

            salesTransaction.MouseEnter += lbl_MouseEnter;
            salesTransaction.MouseLeave += lbl_MouseLeave;
            salesTransaction.Click += lblNav_Click;

            report.MouseEnter += lbl_MouseEnter;
            report.MouseLeave += lbl_MouseLeave;
            report.Click += lblNav_Click;

            salesForecast.MouseEnter += lbl_MouseEnter;
            salesForecast.MouseLeave += lbl_MouseLeave;
            salesForecast.Click += lblNav_Click;

            adminPanel.MouseEnter += lbl_MouseEnter;
            adminPanel.MouseLeave += lbl_MouseLeave;
            adminPanel.Click += lblNav_Click;

            logOut.MouseEnter += lbl_MouseEnter;
            logOut.MouseLeave += lbl_MouseLeave;
            logOut.Click += lblNav_Click;

            // By Default naka show yung Home
            ShowPanel(homePanel, panel2);

            // Custom style for datetime in inventory
            textBox1.Text = DateTime.Now.ToString("MM/dd/yyyy  hh:mm:ss tt");
            textBox2.Text = DateTime.Now.ToString("MM/dd/yyyy  hh:mm:ss tt");
            textBox3.Text = DateTime.Now.ToString("MM/dd/yyyy  hh:mm:ss tt");

            // Sales Transaction Buttons 
            payCashBtn.Enabled = false;
            creditBtn.Enabled = false;



        }
        // When mouse enters (hover), change background to red
        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label; // Get the label that triggered the event

            if (lbl != activeLabel)
            {
                lbl.BackColor = Color.Red;
                activeLabel.BackColor = Color.Transparent;
            }

        }

        // When mouse leaves, reset background to gray
        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label; // Get the label that triggered the event
            if (lbl != activeLabel)
            {
                lbl.BackColor = Color.Transparent;
                activeLabel.BackColor = Color.Red;
            }

        }

        private void lblNav_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            // Reset the previous active label to gray
            if (activeLabel != null)
            {
                activeLabel.BackColor = Color.Transparent;
            }

            // Set the newly clicked label as active
            clickedLabel.BackColor = Color.Red;
            activeLabel = clickedLabel; // Update active label
        }

        private void ShowPanel(Panel panel, Panel headerTitle)
        {
            // By Default all panels are inviisible except HOME
            panel3.Visible = false;
            homePanel.Visible = false;
            salesTransactionPanel.Visible = false;

            // The titles of each label when switched
            panel3HeaderTitle.Visible = false;
            salesTransactionHeaderTitle.Visible = false;


            // this part will show the panel that is clicked
            panel.Visible = true;
            headerTitle.Visible = true;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            ShowPanel(homePanel, panel2);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventoryNav_Click(object sender, EventArgs e)
        {
            ShowPanel(panel3, panel3HeaderTitle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salesTransaction_Click(object sender, EventArgs e)
        {
            ShowPanel(salesTransactionPanel, salesTransactionHeaderTitle);
        }

        private void report_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void salesForecast_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void salesTransactionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3HeaderTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void payCashBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
