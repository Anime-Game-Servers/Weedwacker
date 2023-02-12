using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HomeWorldAreaComfortExcelConfig
{
	public uint configID;
	public uint sceneID;
	public uint areaID;
	public HomeWorldAreaType areaType;
	public uint nameTextMapHash;
	public uint maxComfort;
	public string safePointStr;
	public uint lowLoadLimit;
	public uint middleLoadLimit;
	public uint highLoadLimit;
	public float[] areaCenterPos;
	public float[] areaCenterRot;
}