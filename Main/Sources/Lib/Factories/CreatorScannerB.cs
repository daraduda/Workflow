using Domain.Devices;

namespace Lib.Factories
{
	public class CreatorScannerB : CreatorDevice
	{
		public override void CreateDevice()
		{
			Devices.Add(new ScannerB());
		}
	}
}