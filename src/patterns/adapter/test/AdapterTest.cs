using DesignPatterns.Models;
using DesignPatterns.Patterns;
using System;

namespace DesignPatterns.Test
{
    public class AdapterTest
    {
        private readonly ProcessorJson processor;

        public AdapterTest()
        {
            processor = new ProcessorJson();
        }

        public void Test()
        {
            TestJsonObject();
            TestXmlObject();
            TestExcelObject();
        }

        private void TestJsonObject()
        {
            Json json = new Json()
            {
                Data = "json data"
            };
            string result = "FAIL";

            if (processor.Process(json) == "Processed: " + json.Data)
            {
                result = "PASS";
            }
            Console.WriteLine("TestJsonObject: " + result);
        }

        private void TestXmlObject()
        {
            Xml xml = new Xml()
            {
                Data = "xml data"
            };
            string result = "FAIL";

            if (processor.Process(XmlToJsonAdapter.From(xml)) == "Processed: parsed json data from -> xml data")
            {
                result = "PASS";
            }
            Console.WriteLine("TestXmlObject: " + result);
        }

        private void TestExcelObject()
        {

            ExcelSpreadsheet excel = new ExcelSpreadsheet()
            {
                table = new string[1, 1]
            };
            excel.table[0, 0] = "excel data";
            string result = "FAIL";

            if (processor.Process(ExcelToJsonAdapter.From(excel)) == "Processed: parsed json data from -> excel data")
            {
                result = "PASS";
            }
            Console.WriteLine("TestExcelObject: " + result);
        }
    }
}