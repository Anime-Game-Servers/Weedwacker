using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigHeadControl
{
	public bool useHeadControl;
	public float maxYawDegree;
	public float maxPitchDegree;
	public float speed;
	public float weightSpeed;
	public bool useWhiteAnimStates;
	public string[] animStates;
	public string[] dontAnimStates;
}
