using System.Text.Json.Serialization;

namespace AcademyTest.Repositories{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserTypeEnum{
        Student =0,
        Engineer,
        Manager,
        
    }
}