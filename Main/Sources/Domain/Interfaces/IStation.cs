namespace Domain.Interfaces
{
	public interface IStation
	{
		int Id { get; set; }

		string Name { get; set; }

		IProcess CurrentProcess { get; set; }
	}
}