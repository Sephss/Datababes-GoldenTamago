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

            // Set the DataGridView to read-only mode to prevent user edits
            this.dataGridView2.ReadOnly = true;

            // Disable the ability to add new rows, which removes the asterisk (*) indicator at the end
            this.dataGridView2.AllowUserToAddRows = false;

            // Disable the ability to add new rows, which removes the asterisk (*) indicator at the end
            this.dataGridView3.AllowUserToAddRows = false;

            // Hide both scrollbars
            dataGridView2.ScrollBars = ScrollBars.None;

            // Auto-size columns to fill available space
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Auto-size rows to fit content
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable automatic column sizing
            dataGridView2.AutoGenerateColumns = false;

            // Optional: Remove border
            dataGridView2.BorderStyle = BorderStyle.None;

            // Hide both scrollbars
            dataGridView3.ScrollBars = ScrollBars.None;

            // Auto-size columns to fill available space
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Auto-size rows to fit content
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable automatic column sizing
            dataGridView3.AutoGenerateColumns = false;

            // Optional: Remove border
            dataGridView3.BorderStyle = BorderStyle.None;

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
            // By Default all panels are visible
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
            PopulateDataGridView2();

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


        private void PopulateDataGridView2()
        {
            // Add sample rows to dataGridView2  
            dataGridView2.Rows.Add(
                "Ballpen",                     // Product Size  
                "₱5.05",                       // Piece Price (formatted)  
                "₱152.50",                     // Tray Price (formatted)  
                "₱1,850.00",                   // Case Price (formatted)  
                "Etc",                // Product Description  
                13423                            // Total Number of Eggs (unchanged)  
            );

            dataGridView2.Rows.Add(
                "C2",
                "₱3.89",
                "₱116.67",
                "₱1,400.00",
                "Food",
                48
            );

            dataGridView2.Rows.Add(
                "Coke",
                "₱5.50",
                "₱100.00",
                "₱900.00",
                "Free-range Eggs",
                1542
            );
            dataGridView2.Rows.Add(
               "Corteno",
               "₱4.33",
               "₱130.00",
               "₱1,560.00",
               "Food",
               40016
           );
            dataGridView2.Rows.Add(
              "Folder",
              "₱5.25",
              "₱157.50",
              "₱1,890.00",
              "Etc",
              36163
          );
            dataGridView2.Rows.Add(
             "Max",
             "₱3.85",
             "₱115.00",
             "₱1,380.00",
             "Food",
             99899
         );
            dataGridView2.Rows.Add(
           "Pen",
           "₱5.36",
           "₱130.00",
           "₱1,930.00",
           "Etc",
           90620
       );
            dataGridView2.Rows.Add(
           "Pencil",
           "₱4.31",
           "₱144.17",
           "₱1,730.00",
           "Etc",
           35767
       );
            dataGridView2.Rows.Add(
        "SkyFlakes",
        "₱4.53",
        "₱135.83",
        "₱1,660.00",
        "Food",
        25245
    );

            dataGridView2.Rows.Add(
        "Voice",
        "₱4.11",
        "₱123.33",
        "₱1,450.00",
        "Food",
        10
    );

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
