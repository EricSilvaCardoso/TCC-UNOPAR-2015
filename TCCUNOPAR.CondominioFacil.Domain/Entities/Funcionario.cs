using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCUNOPAR.CondominioFacil.Domain.Entities
{
    public class Funcionario
    {
        public Funcionario()
        {
            FuncionarioID = Guid.NewGuid();
        }

        public Guid FuncionarioID { get; set; }
        public string Nome { get; set; }
        public int Sexo { get; set; }
        public string Apelido { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<TelefoneAss> TelefoneList { get; set; }


    }
}
