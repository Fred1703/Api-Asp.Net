using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string nomeCliente { get; set; }

        public string rgCliente { get; set; }

        public string enderecoCliente { get; set; }

        public string bairroCliente { get; set; }

        public string cidadeCliente { get; set; }

        public string estadoCLiente { get; set; }
        public string CEPCLiente { get; set; }
        public string nascimentoCLiente { get; set; } 
    }
}

