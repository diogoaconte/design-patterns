using DesignPatterns.Models;

namespace DesignPatterns.Patterns.Adapter
{
    public class ExcelToJsonAdapter : AbstractAdapter<ExcelSpreadsheet, Json>, IJson
    {
        private readonly ExcelSpreadsheet excel;
        public static ExcelToJsonAdapter From(ExcelSpreadsheet excel)
        {
            return new ExcelToJsonAdapter(excel);
        }

        public Json Json()
        {
            return Parse(excel);
        }

        protected override Json Parse(ExcelSpreadsheet received)
        {
            var json = new Json
            {
                Data = "parsed json data from -> " + received.Data[0, 0]
            };
            return json;
        }

        private ExcelToJsonAdapter(ExcelSpreadsheet excel)
        {
            this.excel = excel;
        }
    }
}