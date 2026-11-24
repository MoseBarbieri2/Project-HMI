using Newtonsoft.Json;

namespace Template_UMI.web1.Infrastructure
{
    public static class JsonSerializer
    {
        public static string ToJsonCamelCase(object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings { ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver() });
        }
    }
}
