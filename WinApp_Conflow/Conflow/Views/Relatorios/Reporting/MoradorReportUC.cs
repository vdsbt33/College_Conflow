using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conflow.Controllers;
using Conflow.Models.Morador;

namespace Conflow.Reporting
{
    public partial class MoradorReportUC : UserControl
    {
        public MoradorReportUC()
        {
            InitializeComponent();
        }

        MoradorDao moradorDao = new MoradorDao();

        private void MoradorReportUC_Load(object sender, EventArgs e)
        {
            moradorDao.Refresh();
            MoradorBindingSource.DataSource = moradorDao.GetAll();

            reportViewer1.Size = this.Size;
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            moradorDao.Refresh();
            MoradorBindingSource.DataSource = moradorDao.GetAll();

            reportViewer1.RefreshReport();
        }
    }
}
