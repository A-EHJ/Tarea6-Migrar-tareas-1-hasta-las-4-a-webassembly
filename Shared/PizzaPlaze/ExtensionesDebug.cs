using System.Text.Json;

namespace Tarea6.Shared
{
    public static class ExtensionesDebug
    {  
            private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
