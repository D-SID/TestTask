using Validator.Enums;

namespace Validator.Models
{
    public class Row
    {
        public char Symbol { get; set; }

        public int MinCount { get; set; }

        public int MaxCount { get; set; }

        public string Password { get; set; }

        public ValidationStatus ValidationStatus { get; set; } = ValidationStatus.None;
    }
}
