using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBlackScreenAction : ConfigBaseInterAction
{
	public BlackScreenType blackScreenType;
	public float durationToBlack;
	public float durationKeepBlack;
	public float durationFromBlack;
	public bool changeToInteePos;
	public string inteePos;
	public string textMapID;
	public bool textShake;
	public bool useWhiteScreen;
	public bool useTextFade;
	public uint dialogID;
	public bool needWaitClick;
	public float showClickBtnDelayTime;
}