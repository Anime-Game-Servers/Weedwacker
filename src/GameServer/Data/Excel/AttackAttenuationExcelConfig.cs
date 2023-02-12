using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class AttackAttenuationExcelConfig
{
	public string group;
	public float resetCycle;
	public float[] durabilitySequence;
	public float[] enbreakSequence;
	public float[] damageSequence;
}