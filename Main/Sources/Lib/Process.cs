using System;
using System.Collections.Generic;
using Domain.Enums;
using Domain.Interfaces;

namespace Lib
{
	public class Process : IProcess
	{
		private readonly IDictionary<StateTransition, ProcessStateEnum> _transitions = null;

		public Process()
		{
			CurrentState = ProcessStateEnum.Inactive;

			_transitions = new Dictionary<StateTransition, ProcessStateEnum>
			{
				{ new StateTransition(ProcessStateEnum.Inactive, CommandEnum.Exit), ProcessStateEnum.Terminated },
				{ new StateTransition(ProcessStateEnum.Inactive, CommandEnum.Start), ProcessStateEnum.Active },
				{ new StateTransition(ProcessStateEnum.Active, CommandEnum.End), ProcessStateEnum.Inactive },
				{ new StateTransition(ProcessStateEnum.Active, CommandEnum.Pause), ProcessStateEnum.Paused },
				{ new StateTransition(ProcessStateEnum.Paused, CommandEnum.End), ProcessStateEnum.Inactive },
				{ new StateTransition(ProcessStateEnum.Paused, CommandEnum.Resume), ProcessStateEnum.Active }
			};
		}

		public ProcessStateEnum CurrentState { get; private set; }

		public ProcessStateEnum GetNext(CommandEnum command)
		{
			StateTransition transition = new StateTransition(CurrentState, command);

			if (!_transitions.TryGetValue(transition, out var nextState))
				throw new Exception("Invalid transition: " + CurrentState + " -> " + command);
			
			return nextState;
		}

		public ProcessStateEnum MoveNext(CommandEnum command)
		{
			CurrentState = GetNext(command);

			return CurrentState;
		}
	}
}