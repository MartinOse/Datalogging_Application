using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherSystem_RestAPI
{
    class DataExporter
    {
        //static string target = "https://iot.dimensionfour.io/graph";

        public async void ExportData()
        {
            try
            {
                string query = @"{
                ""query"": ""mutation CREATE_SIGNAL (\r\n  $timestamp: Timestamp!\r\n  $pointId: ID!\r\n  $value: String!\r\n  )\r\n  {\r\n  signal {\r\n    create(input: {pointId: $pointId, signals: [{unit: CELSIUS_DEGREES, value: $value, type: \""testtemp\"", timestamp: $timestamp}]}) {\r\n      id\r\n      timestamp\r\n      createdAt\r\n      pointId\r\n      unit\r\n      type\r\n      data {\r\n        numericValue\r\n        rawValue\r\n      }\r\n    }\r\n  }\r\n}"",
                ""variables"": {
                ""pointId"": ""<pointId>"",
                ""timestamp"": ""2021-12-17T14:30:21.000+00:00"",
                ""value"": ""123.45""
                    }
                }";

                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("x-tenant-id", "USN");
                client.DefaultRequestHeaders.Add("x-tenant-key", "<key>");

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
                throw e;
            }
        }

    }
}
