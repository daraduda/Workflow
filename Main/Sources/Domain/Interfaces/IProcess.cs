using Domain.Enums;

namespace Domain.Interfaces
{
	public interface IProcess
	{
		ProcessStateEnum GetNext(CommandEnum command);

		ProcessStateEnum MoveNext(CommandEnum command);
	}
}
