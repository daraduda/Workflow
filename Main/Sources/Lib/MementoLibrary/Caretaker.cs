using System.Collections.Generic;

namespace Lib.MementoLibrary
{
	public static class Caretaker<T>
	{
		private static readonly List<Memento<T>> _mementos = new List<Memento<T>>();

		public static void SaveState(Originator<T> originator)
		{
			_mementos.Add(originator.CreateMemento());
		}

		public static void RestoreState(Originator<T> orig, int stateNumber)
		{
			Memento<T> memento = _mementos[stateNumber];
			orig.SetMemento(memento);
		}
	}
}