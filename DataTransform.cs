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
        public List<string[]> UnpackXML(string xml_string)
        {
            string response = xml_string;
            List<string[]> return_values = new List<string[]>();

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response);

            var nodes = xml.SelectNodes("//oriondata/meas");

            foreach (XmlElement e in nodes)
            {
                string[] nodeVals = new string[2];
                nodeVals[0] = e.GetAttribute("name").ToString();
                nodeVals[1] = e.InnerText.ToString();

                return_values.Add(nodeVals);
            }

            return return_values;

        }
    }
}