using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entity
{
    public class Cliente
    {

        public Cliente() { }

        public int ClienteId { get; set; }
        public String Nome { get; set; }
        public int CPF { get; set; }

    }
}
