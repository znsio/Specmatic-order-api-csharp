using System.Diagnostics.CodeAnalysis;

namespace specmatic_order_api_csharp.filestorage;

[ExcludeFromCodeCoverage]
public static class LocalFileSystem
{
    public static string SaveImage(string imageFileName, byte[] bytes)
    {
        string directoryPath = Path.Combine(".", "images");
        Directory.CreateDirectory(directoryPath);
            
        string filePath = Path.Combine(directoryPath, imageFileName);
        File.WriteAllBytes(filePath, bytes);
            
        return new FileInfo(filePath).FullName;
    }
}