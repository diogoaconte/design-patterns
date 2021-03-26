using DesignPatterns.Models;

namespace DesignPatterns.Patterns
{
    public class XmlToJsonAdapter : AbstractAdapter<Xml, Json>, IJsonAdapter
    {
        private readonly Xml xml;
        
        static public XmlToJsonAdapter From(Xml xml)
        {
            return new XmlToJsonAdapter(xml);
        }

        public Json ToJson()
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