namespace PocKube.API;

using Newtonsoft.Json;

public class HealthCheckExceptionConverter : JsonConverter<Exception>
{
    
    public override void WriteJson(JsonWriter writer, Exception? value, JsonSerializer serializer)
    {
        writer.WriteValue(value?.Message);
    }

    public override Exception ReadJson(JsonReader reader, Type objectType, Exception? existingValue, bool hasExistingValue,
        JsonSerializer serializer) =>
        throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");

    public override bool CanRead => false;
}