using System;
using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Devices
{
	public class Device : IDevice
	{
		public Device(int id, string name, string version, DeviceTypeEnum deviceType)
		{
			Id = id;
			Name = name;
			Version = version;
			DeviceType = deviceType;
		}

		public int Id { get; }
		
		public string Name { get; }

		public string Version { get; }

		public DeviceTypeEnum DeviceType { get; }

		public string DeviceTypeToString()
		{
			switch (DeviceType)
			{
				case DeviceTypeEnum.Scanner:
					return "Scanner";
				case DeviceTypeEnum.Box:
					return "Box";
				case DeviceTypeEnum.None:
					return "Undefined";
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}