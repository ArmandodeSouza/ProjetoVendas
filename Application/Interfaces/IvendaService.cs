using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces {
    public interface IVendaService {
        Task RegistrarVendaAsync(
            int clienteId,
            List<(int produtoId, int quantidade)> itens
        );
    }
}
