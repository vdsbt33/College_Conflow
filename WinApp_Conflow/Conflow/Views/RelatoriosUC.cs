using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conflow.Reporting;
using Conflow.Views.Relatorios;

namespace Conflow.Views
{
    public partial class RelatoriosUC : UserControl
    {
        ProprietarioReportUC proprietarioReportForm = new ProprietarioReportUC();
        MoradorReportUC moradorReportForm = new MoradorReportUC();
        CotaCondominialUC cotaCondominialUC = new CotaCondominialUC();

        public RelatoriosUC()
        {
            InitializeComponent();
        }

        /*
        Função: ResetarScroll()
        Descrição: Reseta o scroll do form em PesquisarOPPanel para evitar que o scroll desapareça ao trocar de usercontrol.
        */
        public void ResetarScroll()
        {
            RelatorioOPPanel.VerticalScroll.Value = 0;
            RelatorioOPPanel.HorizontalScroll.Value = 0;
        }

        private void Relatorio_ProprietarioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            RelatorioOPPanel.Controls.Clear();
            proprietarioReportForm.Size = RelatorioOPPanel.Size;
            RelatorioOPPanel.Controls.Add(proprietarioReportForm);
        }

        private void Relatorio_MoradorBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            RelatorioOPPanel.Controls.Clear();
            moradorReportForm.Size = RelatorioOPPanel.Size;
            RelatorioOPPanel.Controls.Add(moradorReportForm);
        }

        private void cotaBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            RelatorioOPPanel.Controls.Clear();
            moradorReportForm.Size = RelatorioOPPanel.Size;
            RelatorioOPPanel.Controls.Add(cotaCondominialUC);
        }

    }
}
