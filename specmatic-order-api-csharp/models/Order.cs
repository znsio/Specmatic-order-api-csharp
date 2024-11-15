using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace specmatic_order_api_csharp.models;

public class Order
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("productid")]
    public int Productid { get; set; } 
    [JsonPropertyName("count")]
    public int Count { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; } 
}
public enum OrderStatus
{
    Pending,
    Fulfilled,
    Cancelled
}

