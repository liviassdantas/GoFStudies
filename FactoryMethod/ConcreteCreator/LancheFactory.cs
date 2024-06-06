using FactoryMethod.Creator;
using GoFStudies.ConcreteProduct;
using GoFStudies.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class LancheFactory : LancheFactoryMethod
    {
        public override Lanche CriarLanche(int tipo)
        {
            if (tipo == 1)
            {
                return new HotDog();
            }
            else if (tipo == 2)
            {
                return new Frango();
            }
            else if (tipo == 3)
            {
                return new MistoQuente();
            }
            else
            {
                throw new System.ArgumentException("Lanche não encontrada");
            }
        }
    }
}
