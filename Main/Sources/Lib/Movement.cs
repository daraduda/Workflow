using Domain;
using Domain.Enums;
using Domain.Interfaces;

namespace Lib
{
	public class Movement<T> where T : Entity<int>, IMovement
	{
		private readonly BaseStation<T> _station;

		public Movement(BaseStation<T> station)
		{
			_station = station;
		}

		public void Next()
		{
			IProcess process = new Process();
			process.MoveNext(CommandEnum.Start);
		}

		public void Return()
		{
		}
	}
}