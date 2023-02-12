using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigVideoPlayAction : ConfigBaseInterAction
{
	public string videoName;
	public uint subtitleId;
	public bool canSkip;
	public ColorVector bgColor;
	public float fadeInTime;
	public float fadeOutTime;
}