﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using MyUniversalWindows10App.Models;
using Newtonsoft.Json.Linq;

namespace MyUniversalWindows10App.Models
{
    public static partial class SessionCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<Session> DeserializeJson(JToken inputObject)
        {
            IList<Session> deserializedObject = new List<Session>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                Session session = new Session();
                session.DeserializeJson(iListValue);
                deserializedObject.Add(session);
            }
            return deserializedObject;
        }
    }
}
