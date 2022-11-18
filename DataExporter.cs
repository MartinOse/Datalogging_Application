using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WeatherSystem_RestAPI
{
    class DataExporter
    {
        // connection data to Hamed's Dimension Four instance, for testing purposes of the POC
        const string pointId = "63145ae412eee459bff82f9a";
        const string tenantId = "hamed";
        const string tenantKey = "1550b9bf6829b8b3d356875e";
        private static Dictionary<string, string> keyMap_unit;
        private static Dictionary<string, string> keyMap_type;

        public static async void ExportData(List<string[]> dataList)
        {
            

            try
            {

                StringBuilder fields = new StringBuilder();
                StringBuilder signalQuery = new StringBuilder();
                StringBuilder variables = new StringBuilder();

                string mapfile_unit = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mapping_unit.json");
                string mapfile_types = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mapping_types.json");

                //If Map json exists, try to parse and load it into a dictionary
                if (File.Exists(mapfile_unit))
                {
                    string jsonContent = File.ReadAllText(mapfile_unit);
                    if (!string.IsNullOrEmpty(jsonContent))
                    {
                        keyMap_unit = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

                    }
                }

                if (File.Exists(mapfile_types))
                {
                    string jsonContent = File.ReadAllText(mapfile_types);
                    if (!string.IsNullOrEmpty(jsonContent))
                    {
                        keyMap_type = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

                    }
                }


                dataList.ForEach(data =>

                {
                    fields.Append($"${data[0]}:String!");

                    signalQuery.Append("{unit: " + keyMap_unit[data[0]] + " value:$" + data[0] + " type:\\\"" + keyMap_type[data[0]] + "\\\" timestamp:$timestamp}, ");

                    variables.Append($",\n\"{data[0]}\":\"{data[1]}\"");

                });


                string query = @"{""query"": ""mutation CREATE_SIGNAL($timestamp:Timestamp!$pointId:ID!" + fields.ToString() + @"){signal{create(input:{pointId:$pointId signals:[" + signalQuery.ToString() + @"]}){id timestamp createdAt pointId unit type data{numericValue rawValue}}}}"",                

                ""variables"": {
                    ""pointId"": """ + pointId + @""",
                    ""timestamp"": """ + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffff") + @""" " + variables.ToString() + @" 
                }
                }"

                .Replace("%pointId%", pointId)
                .Replace("%timestamp%", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"));


                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("x-tenant-id", tenantId);
                client.DefaultRequestHeaders.Add("x-tenant-key", tenantKey);

                var content = new StringContent(query, Encoding.UTF8, "application/json");
                Console.WriteLine(await content.ReadAsStringAsync());

                var response = await client.PostAsync("https://iot.dimensionfour.io/graph", content);
                string respBody = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine();
                Console.WriteLine(respBody);
                Console.WriteLine(response.StatusCode);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
