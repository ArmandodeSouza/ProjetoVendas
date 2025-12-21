using Application.Servivces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Relatorio {
    public partial class FormRelatorio : Form {

        private readonly RelatorioService _relatorioService;

        public FormRelatorio(RelatorioService relatorioService) {

            _relatorioService = relatorioService;

            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e) {
            if (!TryObterDatas(out var dataInicio, out var dataFim))
                return;

            var formRelatorio = new FormVendaReport(
                dataInicio,
                dataFim,
                relatorioService: _relatorioService
            );

            formRelatorio.ShowDialog();
        }

        private bool TryObterDatas(
            out DateTime dataInicio,
            out DateTime dataFim
        ) {
            dataInicio = default;
            dataFim = default;

            if (!mskInicio.MaskCompleted ||
                !mskFim.MaskCompleted) {

                MessageBox.Show("Preencha ambas as datas.");
                return false;
            }

            var cultura = new CultureInfo("pt-BR");

            if (!DateTime.TryParseExact(
                    mskInicio.Text,
                    "dd/MM/yyyy",
                    cultura,
                    DateTimeStyles.None,
                    out dataInicio
                ) ||
                !DateTime.TryParseExact(
                    mskFim.Text,
                    "dd/MM/yyyy",
                    cultura,
                    DateTimeStyles.None,
                    out dataFim
                )) {

                MessageBox.Show("Data inválida.");
                return false;
            }

            if (dataInicio > dataFim) {
                MessageBox.Show("Data inicial maior que a final.");
                return false;
            }

            return true;
        }
    }
}

