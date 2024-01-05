namespace Register;

public abstract class Animal
{
    public string Name { get; set; }

    public abstract string GetInfo();

    public void WriteData()
    {
        Console.WriteLine("Nome: " + Name);
        Console.WriteLine("Informações: " + GetInfo());
    }
}