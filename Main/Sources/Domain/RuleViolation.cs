namespace Domain
{
	public class RuleViolation
	{
		public RuleViolation(string errorMessage)
		{
			ErrorMessage = errorMessage;
		}

		public RuleViolation(string errorMessage, string propertyName)
		{
			ErrorMessage = errorMessage;
			PropertyName = propertyName;
		}

		public string ErrorMessage { get; }

		public string PropertyName { get; }
	}
}