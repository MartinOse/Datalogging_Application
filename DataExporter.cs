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
            string value_mtRawWindDir = values[6];
            string value_mt3SecRollAvgWindSpeed = values[7];
            string value_mt3SecRollAvgWindDir = values[8];
            string value_mt2MinRollAvgWindSpeed = values[9];
            string value_mt2MinRollAvgWindDir = values[10];
            string value_mt10MinRollAvgWindSpeed = values[11];
            string value_mt10MinRollAvgWindDir = values[12];
            string value_mt10MinWindGustDir = values[13];
            string value_mt10MinWindGustSpeed = values[14];
            string value_mt10MinWindGustTime = values[15];
            string value_mt60MinWindGustDir = values[16];
            string value_mt60MinWindGustSpeed = values[17];
            string value_mt60MinWindGustTime = values[18];
            string value_mtSolarRadiation = values[19];
            string value_mtHeatIndex = values[20];
            string value_mtDegreeDay = values[21];
            string value_mtDegreeDayStart = values[22];
            string value_mtRawBaromPress = values[23];
            string value_mtDensityAltitude = values[24];
            string value_mtWetBulbGlobeTemp = values[25];
            string value_mtWetBulbTemp = values[26];
            string value_mtSaturatedVaporPressure = values[27];
            string value_mtVaporPressure = values[28];
            string value_mtDryAirPressure = values[29];
            string value_mtDryAirDensity = values[30];
            string value_mtWetAirDensity = values[31];
            string value_mtAbsoluteHumidity = values[32];
            string value_mtAirDensityRatio = values[33];
            string value_mtAdjustedAltitude = values[34];
            string value_mtSAECorrectionFactor = values[35];
            string value_mtRainThisWeek = values[36];
            string value_mtRainThisMonth = values[37];
            string value_mtRainThisYear = values[38];
            string value_mtRainRate = values[39];
            string value_mtHailToday = values[40];
            string value_mtWindChill = values[41];
            string value_mtDewPoint = values[42];
            string value_mtAvgTempToday = values[43];
            string value_mtHailRate = values[44];




            try
            {
                string query = @"{
                                ""query"": ""mutation CREATE_SIGNAL(\r\n  $timestamp: Timestamp! \r\n  $pointId: ID!\r\n  $value_temp: String!\r\n  $value_pressure: String!\r\n  $value_humidity: String!\r\n  $value_rain: String!\r\n  $value_wind_speed: String!\r\n  $value_wind_dir: String!\r\n  ){\r\n  signal {\r\n    create(input: {\r\n      pointId: $pointId\r\n      
                                signals: 
                                [\r\n        {\r\n          
                                        
                                        unit: CELSIUS_DEGREES\r\n          
                                        value: $value_temp\r\n          
                                        type: \""Temperature\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          

                                        unit: PASCAL\r\n          
                                        value: $value_pressure\r\n          
                                        type: \""Barometric pressure\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },        \r\n        {\r\n          


                                        unit: PERCENTS\r\n          
                                        value: $value_humidity\r\n          
                                        type: \""Relative humidity\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          

                    
                                        unit: UNKNOWN\r\n          
                                        value: $value_rain\r\n          
                                        type: \""Rain gauge\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          


                                        unit: METERS_PER_SECOND\r\n          
                                        value: $value_wind_speed\r\n          
                                        type: \""Rain gauge\""\r\n              
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          


                                        unit: DEGREES\r\n          
                                        value: $value_wind_dir\r\n              
                                        type: \""Wind direction\""\r\n              
                                        timestamp: $timestamp\r\n        
                                        },\r\n         {\r\n
      


                                        unit: UNKNOWN\r\n          
                                        value: $value_mt3SecRollAvgWindSpeed\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n



                                        unit: UNKNOWN\r\n          
                                        value: $value_mt3SecRollAvgWindDir\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: value: $value_mt2MinRollAvgWindSpeed\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt2MinRollAvgWindDir\r\n  
                                        type: \""Rain gauge\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt10MinRollAvgWindSpeed\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt10MinRollAvgWindDir\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mt10MinWindGustDir\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt10MinWindGustDir\r\n  
                                        type: \""Rain gauge\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt10MinWindGustSpeed\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt10MinWindGustTime\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mt60MinWindGustDir\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt60MinWindGustSpeed\r\n  
                                        type: \""Rain gauge\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          

                                        unit: UNKNOWN\r\n          
                                        value: $value_mt60MinWindGustTime\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mtSolarRadiation\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtHeatIndex\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mtDegreeDay\r\n  
                                        type: \""Rain gauge\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          

                                        unit: UNKNOWN\r\n          
                                        value: $value_mtDegreeDayStart\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mtRawBaromPress\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtDensityAltitude\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mtWetBulbGlobeTemp\r\n  
                                        type: \""Rain gauge\""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n          

                                        unit: UNKNOWN\r\n          
                                        value: $value_mtWetBulbTemp\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n

                                        unit: UNKNOWN\r\n          
                                        value: $value_mtSaturatedVaporPressure\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtVaporPressure\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtDryAirPressure\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtDryAirDensity\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtWetAirDensity\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtAbsoluteHumidity\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtAirDensityRatio\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtAdjustedAltitude\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtSAECorrectionFactor\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtRainThisWeek\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtRainThisMonth\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtRainThisYear\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtRainRate\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtHailToday\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtWindChill\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n


                                        unit: UNKNOWN\r\n          
                                        value: $value_mtDewPoint\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n



                                        unit: UNKNOWN\r\n          
                                        value: $value_mtAvgTempToday\r\n  
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n



                                        unit: UNKNOWN\r\n          
                                        value: $value_mtHailRate\r\n            
                                        type: \"" UNKNOWN \""\r\n          
                                        timestamp: $timestamp\r\n        
                                        },\r\n        {\r\n
                                        ]\r\n    })
                                        {\r\n      id\r\n      timestamp\r\n      createdAt\r\n      pointId\r\n      unit\r\n      type\r\n      data {\r\n        numericValue\r\n        rawValue\r\n      }\r\n    }\r\n  }\r\n}"",
                                                                            ""variables"": {
                                        ""pointId"": ""%pointId%"",
                                        ""timestamp"": ""%timestamp%"",
                                        ""value_temp"": ""%value_temp%"",
                                        ""value_pressure"": ""%value_pressure%"",
                                        ""value_humidity"": ""%value_humidity%"",
                                        ""value_rain"": ""%value_rain%"",
                                        ""value_wind_speed"": ""%value_wind_speed%"",
                                        ""value_wind_dir"": ""%value_wind_dir%""
                                        ""value_mt3SecRollAvgWindSpeed "":""%value_mt3SecRollAvgWindSpeed %"",
                                        ""value_mt3SecRollAvgWindDir"":""%value_mt3SecRollAvgWindDir %"",
                                        ""value_mt2MinRollAvgWindSpeed"" : ""%”“value_mt2MinRollAvgWindSpeed %"",
                                        ""value_mt2MinRollAvgWindDir"" : ""%value_mt2MinRollAvgWindDir %"",
                                        ""value_mt10MinRollAvgWindSpeed"" : ""%value_mt10MinRollAvgWindSpeed %"",
                                        ""value_mt10MinRollAvgWindDir"" : ""%value_mt10MinRollAvgWindDir %"",
                                        ""value_mt10MinWindGustDir"" : ""%value_mt10MinWindGustDir %"",
                                        ""value_mt10MinWindGustSpeed"" : ""%value_mt10MinWindGustSpeed %"",
                                        ""value_mt10MinWindGustTime"" : ""%value_mt10MinWindGustTime %"",
                                        ""value_mt60MinWindGustDir"" : ""%value_mt60MinWindGustDir %"",
                                        ""value_mt60MinWindGustSpeed"" : ""%value_mt60MinWindGustSpeed %"",
                                        ""value_mt60MinWindGustTime"" : ""%value_mt60MinWindGustTime %"",
                                        ""value_mtSolarRadiation"" : ""%value_mtSolarRadiation %"",
                                        ""value_mtHeatIndex"" : ""%value_mtHeatIndex %"",
                                        ""value_mtDegreeDay"" : ""%value_mtDegreeDay %"",
                                        ""value_mtDegreeDayStart"" : ""%value_mtDegreeDayStart %"",
                                        ""value_mtRawBaromPress"" : ""%value_mtRawBaromPress %"",
                                        ""value_mtDensityAltitude"" : ""%value_mtDensityAltitude %"",
                                        ""value_mtWetBulbGlobeTemp"" : ""%value_mtWetBulbGlobeTemp %"",
                                        ""value_mtWetBulbTemp"" : ""%value_mtWetBulbTemp %"",
                                        ""value_mtSaturatedVaporPressure"" : ""%value_mtSaturatedVaporPressure %"",
                                        ""value_mtVaporPressure"" : ""%value_mtVaporPressure %"",
                                        ""value_mtDryAirPressure"" : ""%value_mtDryAirPressure %"",
                                        ""value_mtDryAirDensity"" : ""%value_mtDryAirDensity %"",
                                        ""value_mtWetAirDensity"" : ""%value_mtWetAirDensity %"",
                                        ""value_mtAbsoluteHumidity"" : ""%value_mtAbsoluteHumidity %"",
                                        ""value_mtAirDensityRatio"" : ""%value_mtAirDensityRatio %"",
                                        ""value_mtAdjustedAltitude"" : ""%value_mtAdjustedAltitude %"",
                                        ""value_mtSAECorrectionFactor"" : ""%value_mtSAECorrectionFactor %"",
                                        ""value_mtRainThisWeek"" : ""%value_mtRainThisWeek %"",
                                        ""value_mtRainThisMonth"" : ""%value_mtRainThisMonth %"",
                                        ""value_mtRainThisYear"" : ""%value_mtRainThisYear %"",
                                        ""value_mtRainRate"" : ""%value_mtRainRate %"",
                                        ""value_mtHailToday"" : ""%value_mtHailToday %"",
                                        ""value_mtWindChill"" : ""%value_mtWindChill %"",
                                        ""value_mtDewPoint"" : ""%value_mtDewPoint %"",
                                        ""value_mtAvgTempToday"" : ""%value_mtAvgTempToday %"",
                                        ""value_mtHailRate"" : ""%value_mtHailRate %"",

                                    }
                            }"

                .Replace("%pointId%", pointId)
                .Replace("%timestamp%", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"))
                .Replace("%value_temp%", value_temp)
                .Replace("%value_pressure%", value_pressure)
                .Replace("%value_humidity%", value_humidity)
                .Replace("%value_rain%", value_rain)
                .Replace("%value_wind_speed%", value_wind_speed)
                .Replace("%value_wind_dir%", value_wind_dir)
                .Replace("%value_mt3SecRollAvgWindSpeed%", value_mt3SecRollAvgWindSpeed)
                .Replace("%value_mt3SecRollAvgWindDir%", value_mt3SecRollAvgWindDir)
                .Replace("%value_mt2MinRollAvgWindSpeed%", value_mt2MinRollAvgWindSpeed)
                .Replace("%value_mt2MinRollAvgWindDir%", value_mt2MinRollAvgWindDir)
                .Replace("%value_mt10MinRollAvgWindSpeed%", value_mt10MinRollAvgWindSpeed)
                .Replace("%value_mt10MinRollAvgWindDir%", value_mt10MinRollAvgWindDir)
                .Replace("%value_mt10MinWindGustDir%", value_mt10MinWindGustDir)
                .Replace("%value_mt10MinWindGustSpeed%", value_mt10MinWindGustSpeed)
                .Replace("%value_mt10MinWindGustTime%", value_mt10MinWindGustTime)
                .Replace("%value_mt60MinWindGustDir%", value_mt60MinWindGustDir)
                .Replace("%value_mt60MinWindGustSpeed%", value_mt60MinWindGustSpeed)
                .Replace("%value_mt60MinWindGustTime%", value_mt60MinWindGustTime)
                .Replace("%value_mtSolarRadiation%", value_mtSolarRadiation)
                .Replace("%value_mtHeatIndex%", value_mtHeatIndex)
                .Replace("%value_mtDegreeDay%", value_mtDegreeDay)
                .Replace("%value_mtDegreeDayStart%", value_mtDegreeDayStart)
                .Replace("%value_mtRawBaromPress%", value_mtRawBaromPress)
                .Replace("%value_mtDensityAltitude%", value_mtDensityAltitude)
                .Replace("%value_mtWetBulbGlobeTemp%", value_mtWetBulbGlobeTemp)
                .Replace("%value_mtWetBulbTemp%", value_mtWetBulbTemp)
                .Replace("%value_mtSaturatedVaporPressure%", value_mtSaturatedVaporPressure)
                .Replace("%value_mtVaporPressure%", value_mtVaporPressure)
                .Replace("%value_mtDryAirPressure%", value_mtDryAirPressure)
                .Replace("%value_mtDryAirDensity%", value_mtDryAirDensity)
                .Replace("%value_mtWetAirDensity%", value_mtWetAirDensity)
                .Replace("%value_mtAbsoluteHumidity%", value_mtAbsoluteHumidity)
                .Replace("%value_mtAirDensityRatio%", value_mtAirDensityRatio)
                .Replace("%value_mtAdjustedAltitude%", value_mtAdjustedAltitude)
                .Replace("%value_mtSAECorrectionFactor%", value_mtSAECorrectionFactor)
                .Replace("%value_mtRainThisWeek%", value_mtRainThisWeek)
                .Replace("%value_mtRainThisMonth%", value_mtRainThisMonth)
                .Replace("%value_mtRainThisYear%", value_mtRainThisYear)
                .Replace("%value_mtRainRate%", value_mtRainRate)
                .Replace("%value_mtHailToday%", value_mtHailToday)
                .Replace("%value_mtWindChill%", value_mtWindChill)
                .Replace("%value_mtDewPoint%", value_mtDewPoint)
                .Replace("%value_mtAvgTempToday%", value_mtAvgTempToday)
                .Replace("%value_mtHailRate%", value_mtHailRate);



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
