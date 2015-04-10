using System;

namespace TCCUNOPAR.CondominioFacil.Domain.Entities
{
    public class CondominoDependente
    {
        public CondominoDependente()
        {
            CondominoDependenteId = Guid.NewGuid();
        }

        public Guid CondominoDependenteId { get; set; }
        public string Nome { get; set; }
        public int Sexo { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        //public virtual ICollection<Telefone> TelefoneList{ get; set; }
    }
}
