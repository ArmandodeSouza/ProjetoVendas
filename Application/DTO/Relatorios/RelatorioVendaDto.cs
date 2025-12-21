using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Relatorios {
    public class RelatorioVendaDto {

        public int VendaId { get; set; }
        public DateTime DataVenda { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public decimal Total { get; set; }

    }
}
