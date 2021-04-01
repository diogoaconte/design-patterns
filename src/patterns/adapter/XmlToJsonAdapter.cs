using DesignPatterns.Models;

namespace DesignPatterns.Patterns.Adapter
{
    public class XmlToJsonAdapter : AbstractAdapter<Xml, Json>, IJson
    {
        private readonly Xml xml;
        
        static public XmlToJsonAdapter From(Xml xml)
        {
            return new XmlToJsonAdapter(xml);
        }

        public Json Json()
        {
            return Parse(xml);
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