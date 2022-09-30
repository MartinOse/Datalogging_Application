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
            string[] return_values = new string[6];

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response);

            return_values[0] = xml.SelectNodes("descendant::meas[@name=\"mtTemp1\"]")[0].InnerText.ToString();
            return_values[1] = xml.SelectNodes("descendant::meas[@name=\"mtAdjBaromPress\"]")[0].InnerText.ToString();
            return_values[2] = xml.SelectNodes("descendant::meas[@name=\"mtRelHumidity\"]")[0].InnerText.ToString();
            return_values[3] = xml.SelectNodes("descendant::meas[@name=\"mtRainToday\"]")[0].InnerText.ToString();
            return_values[4] = xml.SelectNodes("descendant::meas[@name=\"mtWindSpeed\"]")[0].InnerText.ToString();
            return_values[5] = xml.SelectNodes("descendant::meas[@name=\"mtAdjWindDir\"]")[0].InnerText.ToString();

            return return_values;

        }
    }
}
