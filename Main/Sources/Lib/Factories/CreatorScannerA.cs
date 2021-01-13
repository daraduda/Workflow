using Domain.Devices;

namespace Lib.Factories
{
	public class CreatorScannerA : CreatorDevice
	{
		public override void CreateDevice()
		{
			Devices.Add(new ScannerA());
		}
	}
}