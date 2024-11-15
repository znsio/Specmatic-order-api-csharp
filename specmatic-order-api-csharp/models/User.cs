namespace specmatic_order_api_csharp.models;
using System.Diagnostics.CodeAnalysis;
[ExcludeFromCodeCoverage]
public class User
{
    public User(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}