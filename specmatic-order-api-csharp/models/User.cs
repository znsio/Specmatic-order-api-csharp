namespace specmatic_order_api_csharp.models;

public class User
{
    public User(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}