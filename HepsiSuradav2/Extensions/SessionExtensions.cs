using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HepsiSuradav2.Extensions
{
    public static class SessionExtensions
    {

        public static void SetObject(this ISession session,string key, object value)
        {
            string jsonStr = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonStr);
        }

        public static T GetObject<T>(this ISession session,string key)
        {
            string jsonStr = session.GetString(key);
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
        
    }
}
