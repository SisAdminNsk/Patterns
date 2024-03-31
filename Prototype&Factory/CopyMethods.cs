using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prototype_Factory
{
    public static class CopyMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("Type must be serializable");
            }

            if (object.ReferenceEquals(self, null))
            {
                return default(T);
            }

            using(var stream = new MemoryStream())
            {
                JsonSerializer.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                return JsonSerializer.Deserialize<T>(stream);
            }
        }
    }
}
