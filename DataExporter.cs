using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherSystem_RestAPI
{
    class DataExporter
    {
        // connection data to Hamed's Dimension Four instance, for testing purposes of the POC
        const string pointId = "63145ae412eee459bff82f9a";
        const string tenantId = "hamed";
        const string tenantKey = "1550b9bf6829b8b3d356875e";

        public static async void ExportData(string[] values)
        {
            string value_temp = values[0];
            string value_pressure = values[1];
            string value_humidity = values[2];
            string value_rain = values[3];
            string value_wind_speed = values[4];
            string value_wind_dir = values[5];

            try
            {
                string query = @"{
                                ""query"": ""mutation CREATE_SIGNAL(\r\n  $timestamp: Timestamp! \r\n  $pointId: ID!\r\n  $value_temp: String!\r\n  $value_pressure: String!\r\n  $value_humidity: String!\r\n  $value_rain: String!\r\n  $value_wind_speed: String!\r\n  $value_wind_dir: String!\r\n  ){\r\n  signal {\r\n    create(input: {\r\n      pointId: $pointId\r\n      signals: [\r\n        {\r\n          unit: CELSIUS_DEGREES\r\n          value: $value_temp\r\n          type: \""Temperature\""\r\n          timestamp: $timestamp\r\n        },\r\n        {\r\n          unit: PASCAL\r\n          value: $value_pressure\r\n          type: \""Barometric pressure\""\r\n          timestamp: $timestamp\r\n        },        \r\n        {\r\n          unit: PERCENTS\r\n          value: $value_humidity\r\n          type: \""Relative humidity\""\r\n          timestamp: $timestamp\r\n        },\r\n        {\r\n          unit: UNKNOWN\r\n          value: $value_rain\r\n          type: \""Rain gauge\""\r\n          timestamp: $timestamp\r\n        },\r\n        {\r\n          unit: METERS_PER_SECOND\r\n          value: $value_wind_speed\r\n          type: \""Rain gauge\""\r\n          timestamp: $timestamp\r\n        },\r\n        {\r\n          unit: DEGREES\r\n          value: $value_wind_dir\r\n          type: \""Wind direction\""\r\n          timestamp: $timestamp\r\n        },\r\n      ]\r\n    }) {\r\n      id\r\n      timestamp\r\n      createdAt\r\n      pointId\r\n      unit\r\n      type\r\n      data {\r\n        numericValue\r\n        rawValue\r\n      }\r\n    }\r\n  }\r\n}"",
                                    ""variables"": {
                                        ""pointId"": ""%pointId%"",
                                        ""timestamp"": ""%timestamp%"",
                                        ""value_temp"": ""%value_temp%"",
                                        ""value_pressure"": ""%value_pressure%"",
                                        ""value_humidity"": ""%value_humidity%"",
                                        ""value_rain"": ""%value_rain%"",
                                        ""value_wind_speed"": ""%value_wind_speed%"",
                                        ""value_wind_dir"": ""%value_wind_dir%""
                                    }
                            }"

                .Replace("%pointId%", pointId)
                .Replace("%timestamp%", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"))
                .Replace("%value_temp%", value_temp)
                .Replace("%value_pressure%", value_pressure)
                .Replace("%value_humidity%", value_humidity)
                .Replace("%value_rain%", value_rain)
                .Replace("%value_wind_speed%", value_wind_speed)
                .Replace("%value_wind_dir%", value_wind_dir);

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
                throw e;
            }
        }

    }
}
