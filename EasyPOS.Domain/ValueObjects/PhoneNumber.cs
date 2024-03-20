using System.Text.RegularExpressions;

namespace EasyPOS.Domain.ValueObjects
{
    public partial record PhoneNumber
    {
        private const int DefaultLength = 9;
        private const string Pattern = @"^(?:-*\d-*){8}$";
        private PhoneNumber(string value) => Value = value;
        public static PhoneNumber? Create(string value)
        {
            return !IsValidPhoneNumber(value) ? null : new PhoneNumber(value);
        }
        private string Value { get; init; }

        [GeneratedRegex(Pattern)]
        private static partial Regex PhoneNumberRegex();
        private static bool IsValidPhoneNumber(string value)
        {
            return !string.IsNullOrEmpty(value) ||
                PhoneNumberRegex().IsMatch(value) ||
                value.Length == DefaultLength;
        }
    }
}
