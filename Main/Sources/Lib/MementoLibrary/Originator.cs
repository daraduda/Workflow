using System;

namespace Lib.MementoLibrary
{
	public class Originator<T>
	{
		private T _state;

		public Memento<T> CreateMemento()
		{
			Memento<T> memento = new Memento<T>();
			memento.SetState(_state);

			return memento;
		}

		public void SetMemento(Memento<T> m)
		{
			_state = m.GetState();
		}

		public void SetState(T state)
		{
			this._state = state;
		}

		public void ShowState()
		{
			Console.WriteLine("State {0} has saved.", _state);
		}
	}
}