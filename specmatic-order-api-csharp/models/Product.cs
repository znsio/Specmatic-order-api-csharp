using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace specmatic_order_api_csharp.models;
public class Product
{
    private static int _idCounter = 0;
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("inventory")]
    public int Inventory { get; set; }
    public Product()
    {
        Id = _idCounter++;  // Simple ID generation (increment and assign)
    }
}

public enum ProductType
{
    book,
    food,
    gadget,
    other
}

