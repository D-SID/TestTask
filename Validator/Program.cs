namespace Validator 
{
    class Validator
    {
        static void Main(string[] args)
        {
            string[] lines;
            if (args.Length == 0)
            {
                lines = new string[]
                {
                    "a 1-5: abcdj",
                    "z 2-4: asfalseiruqwo",
                    "b 3-6: bhhkkbbjjjb"
                };
            }
            else
            {
                lines = File.ReadAllLines(args[0]);
            }

            if (lines is not null)
            {
                RowReader rowReader = new();
                PassValidation validation = new();

                var rows = rowReader.Parse(lines);
                validation.ValidateRows(rows);

                foreach ( var row in rows )
                {
                    Console.WriteLine(@$"Password validation: {row.ValidationStatus} by {row.Symbol} {row.MinCount}-{row.MaxCount}    {row.Password}");
                }
                var validPass = rows.Count(x => x.ValidationStatus == Properties.Enums.ValidationStatus.Success);
                Console.WriteLine("The password check is complete.");
                Console.WriteLine(@$"Valid passwords: {validPass}/{rows.Count}");
                Console.ReadLine();
            }

        }
    }

}
