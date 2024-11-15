namespace specmatic_order_api_csharp.exceptions;
using System.Diagnostics.CodeAnalysis;

public class ValidationException(string error) : Exception
{
    public string Error { get; init; } = error;
}