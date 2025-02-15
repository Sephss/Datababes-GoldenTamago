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



        private void label1_Click(object sender, EventArgs e)
        {

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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salesTransaction_Click(object sender, EventArgs e)
        {

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
    }
}
