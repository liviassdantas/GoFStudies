using GoFStudies.Product;

namespace GoFStudies.ConcreteProduct
{
    public class Frango : Lanche
    {
        private readonly string _nomeLanche;

        public Frango()
        {
            _nomeLanche = "Lanche de Franguinho";
            Ingredientes.Add("Peito de frango");
            Ingredientes.Add("Maionese e Tomate");
        }

        public override string Nome { get => _nomeLanche; }
    }
}
