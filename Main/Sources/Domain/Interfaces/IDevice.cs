using Domain.Enums;

namespace Domain.Interfaces
{
	public interface IDevice
	{
		int Id { get; }

		string Name { get; }

		string Version { get; }

		DeviceTypeEnum DeviceType { get; }

		string DeviceTypeToString();
	}
}