using System;
using Domain.Enums;

namespace Lib
{
	public class DeviceAdapter : TargetDevice
	{
		private readonly DummyDevice _device = new DummyDevice();
		private readonly DeviceTypeEnum _deviceTypeEnum = DeviceTypeEnum.None;

		public DeviceAdapter(DeviceTypeEnum deviceTypeEnum) : base(deviceTypeEnum)
		{
			_deviceTypeEnum = deviceTypeEnum;
		}

		public override void Display()
		{
			base.Display();

			switch (_deviceTypeEnum)
			{
				case DeviceTypeEnum.Box:
					Console.WriteLine($"Device Name: {_device.Scanner.Name}\r\nVersion: {_device.Scanner.Version}\r\nDevice Type: {_device.Scanner.DeviceTypeToString()}\r\n");
					break;
				case DeviceTypeEnum.Scanner:
					Console.WriteLine($"Device Name: {_device.Box.Name}\r\nVersion: {_device.Box.Version}\r\nDevice Type: {_device.Box.DeviceTypeToString()}\r\n");
					break;
				case DeviceTypeEnum.None:
					Console.WriteLine("Undefined");
					break;
			}
		}
	}
}