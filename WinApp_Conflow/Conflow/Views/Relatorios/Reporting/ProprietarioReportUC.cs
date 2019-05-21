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
using Conflow.Models.Proprietario;

namespace Conflow.Views.Relatorios
{
    public partial class ProprietarioReportUC : UserControl
    {
        public ProprietarioReportUC()
        {
            InitializeComponent();
        }

        ProprietarioDao proprietarioDao = new ProprietarioDao();

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            proprietarioDao.Refresh();
            ProprietarioBindingSource.DataSource = proprietarioDao.GetAll();

            reportViewer1.Size = this.Size;
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            proprietarioDao.Refresh();
            ProprietarioBindingSource.DataSource = proprietarioDao.GetAll();
            
            reportViewer1.RefreshReport();
        }
    }
}
