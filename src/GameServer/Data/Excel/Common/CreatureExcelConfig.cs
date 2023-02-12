
namespace Weedwacker.GameServer.Data;

public class CreatureExcelConfig : EntityExcelConfig
{
	public float hp_base;
	public float attack_base;
	public float defense_base;
	public float critical;
	public float antiCritical;
	public float criticalHurt;
	public float fireSubHurt;
	public float grassSubHurt;
	public float waterSubHurt;
	public float elecSubHurt;
	public float windSubHurt;
	public float iceSubHurt;
	public float rockSubHurt;
	public float fireAddHurt;
	public float grassAddHurt;
	public float waterAddHurt;
	public float elecAddHurt;
	public float windAddHurt;
	public float iceAddHurt;
	public float rockAddHurt;
	public FightPropGrowConfig[] propGrowCurves;
	public float elementMastery;
	public float physicalSubHurt;
	public float physicalAddHurt;
	public byte prefabPathRagdollHashPre;
	public uint prefabPathRagdollHashSuffix;
}