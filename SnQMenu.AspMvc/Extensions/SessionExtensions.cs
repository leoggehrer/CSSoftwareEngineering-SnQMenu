﻿//@CodeCopy
//MdStart
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace SnQMenu.AspMvc.Extensions
{
    public static partial class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            string strValue = JsonSerializer.Serialize(value);

            session.SetString(key, strValue);
        }

        public static T Get<T>(this ISession session, string key)
        {
            var strValue = session.GetString(key);

            return strValue == null ? default(T) : JsonSerializer.Deserialize<T>(strValue);
        }
    }
}
//MdEnd
