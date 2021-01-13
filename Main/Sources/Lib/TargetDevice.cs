using System;
using Domain.Enums;

namespace Lib
{
	public class TargetDevice
	{
		private readonly DeviceTypeEnum _deviceTypeEnum = DeviceTypeEnum.None;

		public TargetDevice(DeviceTypeEnum deviceTypeEnum)
		{
			_deviceTypeEnum = deviceTypeEnum;
		}

		public virtual void Display()
		{
			Console.WriteLine("Connection to device: {0}", _deviceTypeEnum);
		}
	}
}