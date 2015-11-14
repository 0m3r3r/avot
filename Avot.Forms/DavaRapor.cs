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
    public partial class DavaRapor : Form
    {
        public DavaRapor()
        {
            InitializeComponent();
        }

        private void DavaRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DavaReport.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DavaReport.DataTable1);
            this.reportViewer1.RefreshReport();
        }
    }
}
