using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Aplicacao.DTO
{
    public class PratoDTO : BaseDTO
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
