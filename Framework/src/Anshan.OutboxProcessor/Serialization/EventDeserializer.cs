using System;
using Anshan.Domain;
using Newtonsoft.Json;

namespace Anshan.OutboxProcessor.Serialization
{
    public static class EventDeserializer
    {
        private static readonly JsonSerializerSettings Settings;

        static EventDeserializer()
        {
            Settings = new JsonSerializerSettings();
        }

        public static IDomainEvent Deserialize(Type type, string body)
        {
            return JsonConvert.DeserializeObject(body, type, Settings) as IDomainEvent;
        }
    }
}