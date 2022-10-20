using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherSystem_RestAPI
{
    internal class DataTransform
    {
        public string[] UnpackXML(string xml_string)
        {
            string response = xml_string;
            string[] return_values = new string[45];

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response);

            return_values[0] = xml.SelectNodes("descendant::meas[@name=\"mtTemp1\"]")[0].InnerText.ToString();
            return_values[1] = xml.SelectNodes("descendant::meas[@name=\"mtAdjBaromPress\"]")[0].InnerText.ToString();
            return_values[2] = xml.SelectNodes("descendant::meas[@name=\"mtRelHumidity\"]")[0].InnerText.ToString();
            return_values[3] = xml.SelectNodes("descendant::meas[@name=\"mtRainToday\"]")[0].InnerText.ToString();
            return_values[4] = xml.SelectNodes("descendant::meas[@name=\"mtWindSpeed\"]")[0].InnerText.ToString();
            return_values[5] = xml.SelectNodes("descendant::meas[@name=\"mtAdjWindDir\"]")[0].InnerText.ToString();
            return_values[6] = xml.SelectNodes("descendant::meas[@name=\"mtRawWindDir\"]")[0].InnerText.ToString();
            return_values[7] = xml.SelectNodes("descendant::meas[@name=\"mt3SecRollAvgWindSpeed\"]")[0].InnerText.ToString();
            return_values[8] = xml.SelectNodes("descendant::meas[@name=\"mt3SecRollAvgWindDir\"]")[0].InnerText.ToString();
            return_values[9] = xml.SelectNodes("descendant::meas[@name=\"mt2MinRollAvgWindSpeed\"]")[0].InnerText.ToString();
            return_values[10] = xml.SelectNodes("descendant::meas[@name=\"mt2MinRollAvgWindDir\"]")[0].InnerText.ToString();
            return_values[11] = xml.SelectNodes("descendant::meas[@name=\"mt10MinRollAvgWindSpeed\"]")[0].InnerText.ToString();
            return_values[12] = xml.SelectNodes("descendant::meas[@name=\"mt10MinRollAvgWindDir\"]")[0].InnerText.ToString();
            return_values[13] = xml.SelectNodes("descendant::meas[@name=\"mt10MinWindGustDir\"]")[0].InnerText.ToString();
            return_values[14] = xml.SelectNodes("descendant::meas[@name=\"mt10MinWindGustSpeed\"]")[0].InnerText.ToString();
            return_values[15] = xml.SelectNodes("descendant::meas[@name=\"mt10MinWindGustTime\"]")[0].InnerText.ToString();
            return_values[16] = xml.SelectNodes("descendant::meas[@name=\"mt60MinWindGustDir\"]")[0].InnerText.ToString();
            return_values[17] = xml.SelectNodes("descendant::meas[@name=\"mt60MinWindGustSpeed\"]")[0].InnerText.ToString();
            return_values[18] = xml.SelectNodes("descendant::meas[@name=\"mt60MinWindGustTime\"]")[0].InnerText.ToString();
            return_values[19] = xml.SelectNodes("descendant::meas[@name=\"mtSolarRadiation\"]")[0].InnerText.ToString();
            return_values[20] = xml.SelectNodes("descendant::meas[@name=\"mtHeatIndex\"]")[0].InnerText.ToString();
            return_values[21] = xml.SelectNodes("descendant::meas[@name=\"mtDegreeDay\"]")[0].InnerText.ToString();
            return_values[22] = xml.SelectNodes("descendant::meas[@name=\"mtDegreeDayStart\"]")[0].InnerText.ToString();
            return_values[23] = xml.SelectNodes("descendant::meas[@name=\"mtRawBaromPress\"]")[0].InnerText.ToString();
            return_values[24] = xml.SelectNodes("descendant::meas[@name=\"mtDensityAltitude\"]")[0].InnerText.ToString();
            return_values[25] = xml.SelectNodes("descendant::meas[@name=\"mtWetBulbGlobeTemp\"]")[0].InnerText.ToString();
            return_values[26] = xml.SelectNodes("descendant::meas[@name=\"mtWetBulbTemp\"]")[0].InnerText.ToString();
            return_values[27] = xml.SelectNodes("descendant::meas[@name=\"mtSaturatedVaporPressure\"]")[0].InnerText.ToString();
            return_values[28] = xml.SelectNodes("descendant::meas[@name=\"mtVaporPressure\"]")[0].InnerText.ToString();
            return_values[29] = xml.SelectNodes("descendant::meas[@name=\"mtDryAirPressure\"]")[0].InnerText.ToString();
            return_values[30] = xml.SelectNodes("descendant::meas[@name=\"mtDryAirDensity\"]")[0].InnerText.ToString();
            return_values[31] = xml.SelectNodes("descendant::meas[@name=\"mtWetAirDensity\"]")[0].InnerText.ToString();
            return_values[32] = xml.SelectNodes("descendant::meas[@name=\"mtAbsoluteHumidity\"]")[0].InnerText.ToString();
            return_values[33] = xml.SelectNodes("descendant::meas[@name=\"mtAirDensityRatio\"]")[0].InnerText.ToString();
            return_values[34] = xml.SelectNodes("descendant::meas[@name=\"mtAdjustedAltitude\"]")[0].InnerText.ToString();
            return_values[35] = xml.SelectNodes("descendant::meas[@name=\"mtSAECorrectionFactor\"]")[0].InnerText.ToString();
            return_values[36] = xml.SelectNodes("descendant::meas[@name=\"mtRainThisWeek\"]")[0].InnerText.ToString();
            return_values[37] = xml.SelectNodes("descendant::meas[@name=\"mtRainThisMonth\"]")[0].InnerText.ToString();
            return_values[38] = xml.SelectNodes("descendant::meas[@name=\"mtRainThisYear\"]")[0].InnerText.ToString();
            return_values[39] = xml.SelectNodes("descendant::meas[@name=\"mtRainRate\"]")[0].InnerText.ToString();
            return_values[40] = xml.SelectNodes("descendant::meas[@name=\"mtHailToday\"]")[0].InnerText.ToString();
            return_values[41] = xml.SelectNodes("descendant::meas[@name=\"mtWindChill\"]")[0].InnerText.ToString();
            return_values[42] = xml.SelectNodes("descendant::meas[@name=\"mtDewPoint\"]")[0].InnerText.ToString();
            return_values[43] = xml.SelectNodes("descendant::meas[@name=\"mtAvgTempToday\"]")[0].InnerText.ToString();
            return_values[44] = xml.SelectNodes("descendant::meas[@name=\"mtHailRate\"]")[0].InnerText.ToString();


            return return_values;

        }
    }
}
