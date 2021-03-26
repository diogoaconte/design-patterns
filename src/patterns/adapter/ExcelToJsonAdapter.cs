using DesignPatterns.Models;

namespace DesignPatterns.Patterns
{
    public class ExcelToJsonAdapter : AbstractAdapter<ExcelSpreadsheet, Json>, IJsonAdapter
    {
        private readonly ExcelSpreadsheet excel;
        public static ExcelToJsonAdapter From(ExcelSpreadsheet excel)
        {
            return new ExcelToJsonAdapter(excel);
        }

        public Json ToJson()
        {
            return Parse(excel);
        }

        protected override Json Parse(ExcelSpreadsheet received)
        {
            var json = new Json
            {
                Data = "parsed json data from -> " + received.table[0, 0]
            };
            return json;
        }

        private ExcelToJsonAdapter(ExcelSpreadsheet excel)
        {
            this.excel = excel;
        }
    }
}