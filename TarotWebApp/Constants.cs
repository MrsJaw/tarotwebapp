using System.Text.Json;

namespace TarotWebApp
{
    public static class Constants
    {
        public static readonly string TarotApi = "https://localhost:10001/Tarot";
        public static readonly string GetReadingTypesEndpoint = $"{TarotApi}/reading-types";
        public static readonly string ReadEndpoint = $"{TarotApi}/read/readingType";

        public static readonly JsonSerializerOptions DefaultJsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
    }
}
