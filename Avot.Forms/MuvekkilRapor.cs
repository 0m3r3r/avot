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
    public partial class MuvekkilRapor : Form
    {
        public MuvekkilRapor()
        {
            InitializeComponent();
        }

        private void MuvekkilRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MuvekkilReport.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.MuvekkilReport.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
