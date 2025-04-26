using System.Text.RegularExpressions;

namespace ContainRs.WebApp.Models
{
    public class Email
    {

        private static readonly Regex EmailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public Email(string value)
        {
            if (!EmailRegex.IsMatch(value))
            {
                throw new ArgumentException("E-mail invalido.");
            }

            // lógica de validação
            Value = value;
        }

        public string Value { get; }
    }
}
