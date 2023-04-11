using Validator.Models;
using Validator.Properties.Enums;

namespace Validator
{
    public class PassValidation
    {
        public List<Row> ValidateRows(List<Row> rows)
        {
            foreach (Row row in rows)
            {
                var symbolCount = row.Password.ToArray().Count(x => x == row.Symbol);
                row.ValidationStatus = symbolCount >= row.MinCount && symbolCount <= row.MaxCount 
                    ? ValidationStatus.Success 
                    : ValidationStatus.Fail;
            }
            return rows;
        }
    }
}
