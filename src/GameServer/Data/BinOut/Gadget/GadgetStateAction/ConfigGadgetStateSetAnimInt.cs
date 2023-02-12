using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGadgetStateSetAnimInt : ConfigGadgetStateAction
{
	public string intID;
	public int value;
	public bool syncState;
}