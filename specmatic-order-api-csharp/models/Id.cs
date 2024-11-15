using System.Text.Json.Serialization;

namespace specmatic_order_api_csharp.models;

public class IdResponse(int id)
{
    [JsonPropertyName("id")]public int Id { get; init; } = id;
}