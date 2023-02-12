
namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigSpeedupField : ConfigConstForceField
{
	public float attenuation;
	public bool singleDir;
	public bool triggerVehicle;
	public float stopVelocity;
	public float vehicleTargetFOV;
	public float vehicleTargetFOVDuration;
	public uint vehicleTargetFOVPriority;
	public float vehicleFOVEnterSpeed;
	public float vehicleFOVExitSpeed;
}