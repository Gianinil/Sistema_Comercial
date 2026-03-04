using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaComercial.Models
{

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime Validade { get; set; }
    }

}






