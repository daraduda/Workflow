using Domain.Devices;
using Domain.Enums;
using Domain.Interfaces;

namespace Lib
{
	public class DummyDevice
	{
		public IDevice Scanner
			=> new Device(
				id: 1,
				name: "Device XS-9100",
				version: "0.0.5.0",
				deviceType: DeviceTypeEnum.Scanner);

		public IDevice Box
			=> new Device(
				id: 2,
				name: "Device AA-1000",
				version: "1.2.4.0",
				deviceType: DeviceTypeEnum.Box);
	}
}