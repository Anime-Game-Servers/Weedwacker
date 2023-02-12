using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetToyFeather : ConfigBaseWidgetToy
{
	public bool showOnRadar;
	public string uiCameraEffect;
	public string mainCameraEffect;
	public bool showHint;
	public float showHintDistance;
	public uint[] showHintEntityIDList;
	public string abilityName;
	public uint excludeSuiteIndex;
	public string abilityGroupName;
	public bool isTeam;
}