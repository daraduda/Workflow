using System;
using Domain.Devices;
using Domain.Enums;
using Lib;
using Lib.Factories;
using Lib.MementoLibrary;

namespace ConsoleTestApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Target devices");
			Console.WriteLine("-------------------\r\n");

			TargetDevice targetDeviceBox = new DeviceAdapter(DeviceTypeEnum.Box);
			targetDeviceBox.Display();

			TargetDevice targetDeviceScanner = new DeviceAdapter(DeviceTypeEnum.Scanner);
			targetDeviceScanner.Display();

			Console.WriteLine("Create devices");
			Console.WriteLine("-------------------\r\n");

			CreatorDevice[] devices = new CreatorDevice[2];

			devices[0] = new CreatorScannerA();
			devices[1] = new CreatorScannerB();

			foreach (CreatorDevice device in devices)
			{
				Console.WriteLine("{0}\r\n", device.GetType().Name);
			}

			Console.WriteLine("Process states and commands");
			Console.WriteLine("---------------------------\r\n");

			Process process = new Process();
			Originator<ProcessStateEnum> originator = new Originator<ProcessStateEnum>();

			Console.WriteLine("Current State = " + process.CurrentState);
			ProcessStateEnum processStateStart = process.MoveNext(CommandEnum.Start);
			Console.WriteLine("Command Start: Current State = " + processStateStart);

			originator.SetState(processStateStart);
			Caretaker<ProcessStateEnum>.SaveState(originator);
			originator.ShowState();

			var processStatePause = process.MoveNext(CommandEnum.Pause);
			Console.WriteLine("Command Pause: Current State = " + processStatePause);
			originator.SetState(processStatePause);
			Caretaker<ProcessStateEnum>.SaveState(originator);
			originator.ShowState();

			var processStateEnd = process.MoveNext(CommandEnum.End);
			Console.WriteLine("Command End: Current State = " + processStateEnd);
			originator.SetState(processStateEnd);
			Caretaker<ProcessStateEnum>.SaveState(originator);
			originator.ShowState();

			var processStateExit = process.MoveNext(CommandEnum.Exit);
			Console.WriteLine("Command Exit: Current State = " + processStateExit);
			originator.SetState(processStateEnd);
			Caretaker<ProcessStateEnum>.SaveState(originator);
			originator.ShowState();


			Caretaker<ProcessStateEnum>.RestoreState(originator, 0);
			originator.ShowState();

			Console.ReadLine();
		}
	}
}
