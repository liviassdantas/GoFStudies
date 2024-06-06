using FactoryMethod.ConcreteCreator;
using GoFStudies.Product;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha seu Lanche: ");
        Console.WriteLine("(1)HotDog (2)Frnaguinho (3)Mistão");

        var lancheEscolhido = Convert.ToInt32(Console.ReadLine());
        try
        {
            LancheFactory factory = new LancheFactory();
            Lanche lanche = factory.CriarLanche(lancheEscolhido);
            Console.WriteLine(lanche.Nome);

            foreach (var ingrediente in lanche.Ingredientes)
                Console.WriteLine(ingrediente);

            Console.WriteLine("\nLanche montado com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro :" + ex.Message);
        }

        Console.ReadLine();
    }
}