using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManager;
using Newtonsoft.Json;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var allText = File.ReadAllText("../../../ClinicManager/samplePatients.json");
            var jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings()
            {
                DateFormatString = "dd/MM/yyyy"
            });
            var patients = jsonSerializer.Deserialize<List<Patient>>(new JsonTextReader(new StringReader(allText)));
            
        }
    }
}
