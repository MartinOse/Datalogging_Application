using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherSystem_RestAPI
{
    class DataExporter
    {
        const string pointId = "<pointId>";
        const string tenantId = "weather-station";
        const string tenantKey = "2886e929cb7544fefdc1ddf2";

        public static async void ExportData(double val_temp, double val_pressure, double val_humidity, double val_rain, double val_wind_speed, double val_wind_dir)
        {
            double value_temp = val_temp;
            double value_pressure = val_pressure;
            double value_humidity = val_humidity;
            double value_rain = val_rain;
            double value_wind_speed = val_wind_speed;
            double value_wind_dir = val_wind_dir;

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
                .Replace("%value_temp%", value_temp.ToString())
                .Replace("%value_pressure%", value_pressure.ToString())
                .Replace("%value_humidity%", value_humidity.ToString())
                .Replace("%value_rain%", value_rain.ToString())
                .Replace("%value_wind_speed%", value_wind_speed.ToString())
                .Replace("%value_wind_dir%", value_wind_dir.ToString());

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
