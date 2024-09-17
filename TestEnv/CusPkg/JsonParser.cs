using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestEnv.CusPkg
{
    internal class JsonParser
    {
        public object read_json(string json_file)
        {
            string json_str = File.ReadAllText(json_file);
            var res = JsonConvert.DeserializeObject(json_str);
            return res;
        }
    }
}
