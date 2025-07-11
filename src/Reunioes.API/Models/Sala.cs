namespace Reunioes.API.Models
{
    public class Sala
    {
        public virtual int Id { get; protected set; }
        public required virtual string Nome { get; set; }
        public required virtual int Andar { get; set; }
        public required virtual int QuantidadeAssentos { get; set; }
    }
}