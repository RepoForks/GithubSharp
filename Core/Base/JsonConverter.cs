using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;
using ServiceStack.Text;
using ServiceStack.Text.Json;

namespace GithubSharp.Core.Base
{
    internal static class JsonConverter
    {
        /// <summary>
        /// Serializes the object to a Json string 
        /// </summary>
        internal static string ToJson<T>(this T Obj)
        {
        	return Obj.ToJson();
        }

        /// <summary>
        /// Deserializes
        /// </summary>
        /// <returns></returns>
        internal static T FromJson<T>(string Json)
        {
            if (string.IsNullOrEmpty(Json))
                throw new ArgumentNullException("Json");

        	return Json.FromJson<T>();
        }
    }
}