using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bancario.Models
{
    public class Transacao
    {
        
        public DateTime Data { get; set; }
        public string Tipo { get; set; } // Ex: "Depósito", "Saque", "Transferência"
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return $"{Data:dddd, dd/MM/yyyy HH:mm} - {Tipo} - R$ {Valor:F2}";
        }
    }
}