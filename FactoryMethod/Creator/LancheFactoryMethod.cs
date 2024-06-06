using GoFStudies.Product;

namespace FactoryMethod.Creator
{
    public abstract class LancheFactoryMethod
    {
        public abstract Lanche CriarLanche(int tipo);
    }
}
