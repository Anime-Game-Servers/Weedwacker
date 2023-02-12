using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigTeleportToAction : ConfigBaseInterAction
{
	public Vector position;
	public Vector forward;
	public bool openLongDisTeleport;
	public bool syncForward;
}