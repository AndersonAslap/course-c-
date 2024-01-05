namespace Register;

public class Person 
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string Cep { get; set; }

    public void WriteData()
    {
        Console.WriteLine("Codigo: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("City: " + City);
        Console.WriteLine("Cep: " + Cep);
    }
}