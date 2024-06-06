using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelos
{
    public interface ICuentaBancaria
    {
        decimal Saldo { get; }
        void Depositar(decimal cantidad);
        bool Retirar(decimal cantidad);
        void RealizarCorteMensual();
    }
}

