namespace Register;

public class Product 
{
    private int Id;

    public string Description { get; set; }

    public int Stock { get; }

    public Product()
    {
        Stock = 3;
    }

    public void SetId(int id)
    {
        Id = id;
    }

    public int GetId()
    {
        return Id;
    }

    public void WriteDescription()
    {
        Console.WriteLine(GetId() + " - " + Description);
    }
}