namespace Register;

public class Employeer : PersonF
{
    public string Matricula { get; set; }

    public void WriteMatricula()
    {
        Console.WriteLine("Matricula: " + Matricula);
    }
}