namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services.Storage.Serialization
{
    public interface IJsonSerializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string text);
    }
}