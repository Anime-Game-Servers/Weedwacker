using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class ConfigAirflowField : ConfigConstForceField
{
	public float scale;
	public string stayEffect;
	public string enterEffect;
	public bool autoFly;
	public bool forceHor;
}
