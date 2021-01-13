using System.Collections.Generic;

namespace Domain.Devices
{
	public abstract class CreatorDevice
	{
		public CreatorDevice()
		{
			this.CreateDevice();
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public string Version { get; set; }

		protected IList<Entity<int>> Devices => new List<Entity<int>>();

		public abstract void CreateDevice();
	}
}