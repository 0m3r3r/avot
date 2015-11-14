using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avot.Forms
{
    public partial class MahkemeRapor : Form
    {
        public MahkemeRapor()
        {
            InitializeComponent();
        }

        private void MahkemeRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MahkemeReport.Mahkeme' table. You can move, or remove it, as needed.
            this.MahkemeTableAdapter.Fill(this.MahkemeReport.Mahkeme);
            // TODO: This line of code loads data into the 'mukellefyeniDataSet3.Mahkeme' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
        }
    }
}
