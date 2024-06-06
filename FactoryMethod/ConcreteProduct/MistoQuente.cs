using GoFStudies.Product;

namespace GoFStudies.ConcreteProduct
{
    public class MistoQuente : Lanche
    {
        private readonly string _nomeLanche;

        public MistoQuente()
        {
            _nomeLanche = "Mistão";
            Ingredientes.Add("Pão Francês");
            Ingredientes.Add("Queijo");
            Ingredientes.Add("Requeijão");
            Ingredientes.Add("Presunto");
        }

        public override string Nome { get => _nomeLanche; }
    }
}
