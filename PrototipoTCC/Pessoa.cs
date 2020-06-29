using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrototipoTCC
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public string senhaConfirma { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
    }
}