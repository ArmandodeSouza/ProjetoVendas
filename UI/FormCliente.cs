using Application.Servivces;

namespace UI {
    public partial class FormCliente : Form {

        private readonly ClienteService _clienteService;

        public FormCliente(ClienteService clienteService) {
            InitializeComponent();
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        private void btnTelaCadastroCli_Click(object sender, EventArgs e) {
            var formCadastroCli = new FormCadastroCli(_clienteService);
            formCadastroCli.Show();
        }

        private void btnTelaCadastroCli_Click_1(object sender, EventArgs e) {
            var formCadastroCli = new FormCadastroCli(_clienteService);
            formCadastroCli.Show();
        }
    }
}
