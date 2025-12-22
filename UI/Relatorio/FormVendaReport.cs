using Application.DTO.Relatorios;
using Application.Servivces;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Relatorio {
    public partial class FormVendaReport : Form {

        private readonly DateTime _dataInicio;
        private readonly DateTime _dataFim;
        private readonly RelatorioService _relatorioService;

        public FormVendaReport(
            DateTime dataInicio,
            DateTime dataFim,
            RelatorioService relatorioService) {
            InitializeComponent();

            _dataInicio = dataInicio;
            _dataFim = dataFim;
            _relatorioService = relatorioService;
        }

        private async Task CarregarRelatorioAsync() {

            List<RelatorioVendaDto> dados = await _relatorioService.GerarRelatorioVendasAsync(_dataInicio, _dataFim);
            reportViewer1.Reset();
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Relatorio.RptVendas.rdlc";

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DsVendas", dados));

            var periodo = $"Período: {_dataInicio:dd/MM/yyyy} até {_dataFim:dd/MM/yyyy}";

            reportViewer1.LocalReport.SetParameters(new ReportParameter("Periodo", periodo));

            reportViewer1.RefreshReport();


        }

        private async void FormRelatorioVendas_Load(
            object sender,
            EventArgs e
        ) {
            var inicio = _dataInicio;
            var fim = _dataFim;

            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            await CarregarRelatorioAsync();
        }

    }
}

