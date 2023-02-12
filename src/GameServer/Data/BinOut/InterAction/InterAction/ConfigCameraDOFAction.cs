using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCameraDOFAction : ConfigBaseInterAction
{
	public bool enabled;
	public float focusDistance;
	public float focusRange;
	public float nearFocalDistance;
	public float nearFocalTransDistance;
	public float dofBlurAmount;
	public uint quality;
}