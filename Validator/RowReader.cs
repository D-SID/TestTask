using Validator.Models;
using System.Text.RegularExpressions;

namespace Validator
{
    public class RowReader
    {
        public List<Row> Parse(string[] rows)
        {
            List<Row> result = new();

            foreach (string row in rows)
            {
                Row resultRow = new();
                var rowSplit = row.Split(' ');
                resultRow.Symbol = char.Parse(rowSplit[0]);
                resultRow.MinCount = int.Parse(Regex.Match(rowSplit[1], @"^[\d]+").Value);
                resultRow.MaxCount = int.Parse(Regex.Match(rowSplit[1], @"[\d]+:").Value.TrimEnd(':'));
                resultRow.Password = rowSplit[2];
                result.Add(resultRow);
            }
            return result;
        }
    }
}
