using Domain.Enums;

namespace Lib
{
	internal class StateTransition
	{
		private readonly ProcessStateEnum _currentState;
		private readonly CommandEnum _command;

		public StateTransition(ProcessStateEnum currentState, CommandEnum command)
		{
			_currentState = currentState;
			_command = command;
		}

		public override int GetHashCode()
		{
			return _currentState.GetHashCode() + _command.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			StateTransition other = (StateTransition) obj;

			return other != null
			       && _currentState == other._currentState
			       && _command == other._command;
		}
	}
}