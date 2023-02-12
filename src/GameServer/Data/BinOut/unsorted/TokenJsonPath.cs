using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TokenJsonPath
{
	public LogicOperation op;
	public string inheritFrom;
	public string[] hasProperties;
	public string[] paths;
	public TokenJsonPath[] children;
}