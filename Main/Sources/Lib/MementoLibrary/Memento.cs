namespace Lib.MementoLibrary
{
	public class Memento<T>
	{
		private T _state;

		public T GetState()
		{
			return _state;
		}

		public void SetState(T state)
		{
			this._state = state;
		}
	}
}