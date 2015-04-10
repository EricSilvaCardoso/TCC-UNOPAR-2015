using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCUNOPAR.CondominioFacil.Domain.Entities
{
    public class TelefoneAss
    {
        public TelefoneAss()
        {
            TelefoneAssId = Guid.NewGuid();
        }

        public Guid TelefoneAssId { get; set; }
        public string Numero { get; set; }
    }
}
