namespace Register;

public class PersonF : Person
{
    public string CPF { get; set; }

    public void WriteCpf()
    {
        Console.WriteLine("CPF: " + CPF);
    }
}