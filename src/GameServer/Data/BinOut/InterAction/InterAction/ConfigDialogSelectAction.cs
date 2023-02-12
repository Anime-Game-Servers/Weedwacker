using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigDialogSelectAction : ConfigBaseInterAction
{
	public uint[] talkIDList;
	public uint[] dialogIDList;
	public uint[] grpIDList;
	public bool useGrpId;
}