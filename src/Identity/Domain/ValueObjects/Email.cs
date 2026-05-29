using System;

namespace Identity.Domain.ValueObjects
{
    public sealed class Email : IEquatable<Email>
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Email Create(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.", nameof(email));

            var normalized = email.Trim();
            if (!IsValidEmail(normalized))
                throw new ArgumentException("Email is not valid.", nameof(email));

            return new Email(normalized);
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return string.Equals(address.Address, email, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        public override bool Equals(object obj) => Equals(obj as Email);

        public bool Equals(Email other) => other != null && string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);

        public override int GetHashCode() => StringComparer.OrdinalIgnoreCase.GetHashCode(Value);

        public override string ToString() => Value;

        public static implicit operator string(Email email) => email?.Value;

        public static explicit operator Email(string email) => Create(email);
    }
}
