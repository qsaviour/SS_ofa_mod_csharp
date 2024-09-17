using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestEnv.CusPkg;
using Newtonsoft.Json.Linq;


namespace TestEnv
{
    internal class Program
    {
        

        static void Main(string[] args)

        {
            JsonParser json_reader = new JsonParser();
            JObject json_data = (JObject)json_reader.read_json("E:\\IMModels\\ModProject\\Dance\\Scripts\\cache\\env\\ofa_env.json");
            CommonEnvParser commonEnvParser = new CommonEnvParser();
            OtherEnvParser otherEnvParser = new OtherEnvParser();
            StgEnvParser stgEnvParser = new StgEnvParser();
            BpmParser bpmParser = new BpmParser();
            CutoffParser cutoffParser = new CutoffParser();
            GimmickParser gimmickParser = new GimmickParser();  


            string source_folder = "E:\\IMModels\\ModProject\\Dance\\Scripts\\cache\\env\\source";
            string target_folder = "E:\\IMModels\\ModProject\\Dance\\Song_bnd\\output\\Sequence\\Live\\Sng026"; // <<-- need modified
            Directory.CreateDirectory(target_folder);
            commonEnvParser.parse(source_folder, target_folder);
            otherEnvParser.parse(source_folder,target_folder);
            stgEnvParser.parse(source_folder, target_folder);
            bpmParser.parse(source_folder, target_folder);
            cutoffParser.parse(source_folder, target_folder);
            gimmickParser.parse(source_folder, target_folder);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

    }

}
