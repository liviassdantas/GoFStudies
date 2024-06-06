using System.Collections;

namespace GoFStudies.Product
{
    public abstract class Lanche
    {
        public abstract string Nome { get; }

        public ArrayList Ingredientes = new ArrayList();
    }
}
