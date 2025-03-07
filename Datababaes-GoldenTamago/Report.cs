using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datababaes_GoldenTamago
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();

            // to be continue
            loadPanelScene(homePanel);
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
        private void loadPanelScene(Panel panel) {
            reportPanel.Visible = false;
            homePanel.Visible = false;

            panel.Visible = true;
        }
    }
}
