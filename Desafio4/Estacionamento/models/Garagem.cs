using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.models
{
    internal class Garagem
    {
        public static bool TemVaga(List<Veiculo> listaVeiculos)
        {
            if (listaVeiculos == null) return true;

            if(listaVeiculos.Count < 50) return true;

            return false;
        }
    }
}
