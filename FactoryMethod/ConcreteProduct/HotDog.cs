using GoFStudies.Product;

namespace GoFStudies.ConcreteProduct
{
    public class HotDog : Lanche
    {
        private readonly string _nomeLanche;

        public HotDog() {
            _nomeLanche = "HotDog";
            Ingredientes.Add("Pão de Hot Dog");
            Ingredientes.Add("Salsicha");
            Ingredientes.Add("Molho");
            Ingredientes.Add("Batata Palha");
            Ingredientes.Add("Ketchup");
            Ingredientes.Add("Maionese");
        }

        public override string Nome { get => _nomeLanche;}
    }
}
