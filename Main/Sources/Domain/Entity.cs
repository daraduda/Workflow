using System.Collections.Generic;

namespace Domain
{
	public class Entity<T>
	{
		public virtual T Id { get; set; }

		public string Version { get; set; }

		public virtual Entity<T> Duplicate()
		{
			Entity<T> entity = (Entity<T>) MemberwiseClone();

			entity.Id = default(T);
			entity.Version = "0.0";

			return entity;
		}

		public static int GetHashCode(object obj)
		{
			return obj == null ? 0 : obj.GetHashCode();
		}

		public static int GetHashCode(object obj1, params object[] objs)
		{
			int result = GetHashCode(obj1);

			foreach (object obj in objs)
				result = unchecked(result + GetHashCode(obj));

			return result;
		}

		public static int GetHashCode(int hashCode1, params int[] hashCodes)
		{
			int result = hashCode1;

			foreach (int hashCode in hashCodes)
				result = unchecked(result + hashCode);

			return result;
		}

		public override int GetHashCode()
		{
			return GetHashCode(Id);
		}

		public bool IsTransient()
		{
			return Id == null || Id.Equals(default(T));
		}

		public virtual IEnumerable<RuleViolation> GetRuleViolations()
		{
			return new List<RuleViolation>();
		}
	}
}