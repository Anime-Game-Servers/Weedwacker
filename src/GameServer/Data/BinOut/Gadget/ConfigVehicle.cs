using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigVehicle
{
	public VehicleType vehicleType;
	public PlayModeType playMode;
	public string cameraMode;
	public uint maxSeatCount;
	public ConfigVehicleSeat[] seats;
	public uint defaultLevel;
	public uint serverBuffId;
	public ConfigVehicleStamina stamina;

	public class ConfigVehicleSeat
	{
		public string attachTo;
		public uint optionID;
		public Vector rotate;
		public float offVehicleUpDist;
	}
	public class ConfigVehicleStamina
	{
		public float staminaUpperLimit;
		public float staminaRecoverSpeed;
		public float staminaRecoverWaitTime;
		public float extraStaminaUpperLimit;
		public float sprintStaminaCost;
		public float dashStaminaCost;
	}
}