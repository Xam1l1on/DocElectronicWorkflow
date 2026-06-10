namespace Identity.Domain.ValueObjects
{

    public sealed class FullName : IEquatable<FullName>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string DisplayName => $"{FirstName} {LastName}".Trim();

        private FullName(string firstName, string lastName)
        {
            FirstName = firstName ?? string.Empty;
            LastName = lastName ?? string.Empty;
        }

        public static FullName Create(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("At least first name or last name is required.");

            return new FullName(firstName?.Trim() ?? string.Empty, lastName?.Trim() ?? string.Empty);
        }

        public override bool Equals(object? obj) => Equals(obj as FullName);

        public bool Equals(FullName? other) =>
            other != null &&
            string.Equals(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase) &&
            string.Equals(LastName, other.LastName, StringComparison.OrdinalIgnoreCase);

        public override int GetHashCode() =>
            HashCode.Combine(
                StringComparer.OrdinalIgnoreCase.GetHashCode(FirstName),
                StringComparer.OrdinalIgnoreCase.GetHashCode(LastName)
            );

        public override string ToString() => DisplayName;
    }
}