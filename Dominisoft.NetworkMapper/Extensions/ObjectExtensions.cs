using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominisoft.NetworkMapper.Static;
using Newtonsoft.Json;

namespace Dominisoft.NetworkMapper.Extensions
{
    public static class ObjectExtensions
    {
        public static string Serialize<TObject>(this TObject obj)
            => JsonConvert.SerializeObject(obj);
        public static TObject Deserialize<TObject>(this string str)
            => JsonConvert.DeserializeObject<TObject>(str);

        public static void SaveToFile<TObject>(this TObject obj, string fileName)
            => File.WriteAllText($"{GlobalConfig.SaveDirectory}\\{fileName}.json", obj.Serialize());

        public static TObject LoadFromFile<TObject>(this TObject obj, string fileName) where TObject:new()
        {
            var file = $"{GlobalConfig.SaveDirectory}\\{fileName}.json";
            if (!File.Exists(file)) return new TObject();
            return File.ReadAllText(file).Deserialize<TObject>();
        }
    }
}
