using System.Text.Json.Serialization;

namespace PersonalBlog.src.utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserType
    {
        NORMAL,
        ADMIN
    }
}
