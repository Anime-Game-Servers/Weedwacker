using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMoveToAction : ConfigBaseInterAction
{
	public MoveToType moveType;
	public Vector[] routeList;
	public bool exactlyMove;
	public MoveToDirectionType moveDirType;
	public bool closeNavMesh;
	public float directMoveSpeed;
}