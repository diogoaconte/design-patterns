using DesignPatterns.Models;

namespace DesignPatterns.Patterns
{
    public class XmlToJsonAdapter : AbstractAdapter<Xml, Json>, IJson
    {
        private readonly Xml xml;
        static public XmlToJsonAdapter From(Xml xml)
        {
            return new XmlToJsonAdapter(xml);
        }

        public string extractData()
        {
            return Parse(xml).extractData();
        }
        override protected Json Parse(Xml xml)
        {
            var json = new Json()
            {
                Data = "parsed json data from -> " + xml.Data
            };
            return json;
        }

        private XmlToJsonAdapter(Xml xml)
        {
            this.xml = xml;
        }
    }
}