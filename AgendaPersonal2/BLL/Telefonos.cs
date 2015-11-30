using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Telefonos
    {
        public int TelefonoId { set; get; }
        public string Numero { set; get; }

        public Telefonos() {
            this.TelefonoId = 0;
            this.Numero = "";
        }

        public Telefonos(int TelefonoId, string Numero) {
            this.TelefonoId = TelefonoId;
            this.Numero = Numero;
        }
    }
}
