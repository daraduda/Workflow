using System.Collections.Generic;
using Domain.Devices;
using Domain.Interfaces;

namespace Domain
{
	public partial class BaseStation <T> where T : Entity<int>
	{
		public string Name { get; set; }

		public IProcess CurrentProcess { get; set; }

		public IList<CreatorDevice> Devices { get; set; }
	}
}