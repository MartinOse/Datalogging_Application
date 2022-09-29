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
            /*
            XmlNodeList xmlNodes = xml.SelectNodes("/oriondata/");

            foreach (XmlNode xmlNode in xmlNodes)
            {
                return_values[0] = xmlNode["meas name=\"mtTemp1\""].InnerText.ToString();
                return_values[1] = xmlNode["meas name=\"mtAdjBaromPress\""].InnerText.ToString();
                return_values[2] = xmlNode["meas name=\"mtRelHumidity\""].InnerText.ToString();
                return_values[3] = xmlNode["meas name=\"mtRainToday\""].InnerText.ToString();
                return_values[4] = xmlNode["meas name=\"mtWindSpeed\""].InnerText.ToString();
                return_values[5] = xmlNode["meas name=\"mtAdjWindDir\""].InnerText.ToString();
            }
            */

            return_values[0] = xml.GetElementsByTagName("meas name=\"mtTemp1\"")[0].InnerText.ToString();
            return_values[1] = xml.GetElementsByTagName("meas name=\"mtAdjBaromPress\"")[0].InnerText.ToString();
            return_values[2] = xml.GetElementsByTagName("meas name=\"mtRelHumidity\"")[0].InnerText.ToString();
            return_values[3] = xml.GetElementsByTagName("meas name=\"mtRainToday\"")[0].InnerText.ToString();
            return_values[4] = xml.GetElementsByTagName("meas name=\"mtWindSpeed\"")[0].InnerText.ToString();
            return_values[5] = xml.GetElementsByTagName("meas name=\"mtAdjWindDir\"")[0].InnerText.ToString();

            return return_values;

        }
    }
}
