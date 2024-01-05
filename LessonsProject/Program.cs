using Register;

namespace Application;

public class Program
{
    private static void Main(string[] args)
    {
        AbstractClass();
    }

    public static void PropReadonly() 
    {
        var product = new Product();
        product.SetId(1);
        product.Description = "Teclado";
        Console.WriteLine(product.Stock);
    }

    public static void Product()
    {
        var result = Calculate.Sum(1, 6);
        Console.WriteLine(result);

        var product = new Product();
        product.SetId(1);
        product.Description = "Teclado";
        product.WriteDescription();
    }

    public static void Heranca()
    {
        Console.WriteLine("---- pessoa física ----");
        var personf = new PersonF();
        personf.Id = 1;
        personf.CPF = "12508030473";
        personf.Name = "Aslap";
        personf.Address = "Rua 44";
        personf.City = "Abreu e Lima";
        personf.Cep = "00000-000";
        personf.WriteData();
        personf.WriteCpf();

        Console.WriteLine();

        Console.WriteLine("---- funcionário ----");
        var employeer = new Employeer();
        employeer.Id = 1;
        employeer.CPF = "12508030473";
        employeer.Matricula = "xxx-12";
        employeer.Name = "Aslap";
        employeer.Address = "Rua 44";
        employeer.City = "Abreu e Lima";
        employeer.Cep = "00000-000";
        employeer.WriteData();
        employeer.WriteCpf();
        employeer.WriteMatricula();
    }

    public static void SeleadClass()
    {
        var conf = new Configuration
        {
            Host = "192.168.2.2"
        };

        Console.WriteLine(conf.Host);
    }

    public static void AbstractClass()
    {
        var dog = new Dog 
        {
            Name = "bob"
        };
        dog.WriteData();
    }

}