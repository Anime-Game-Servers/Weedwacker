using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class QTEExcelConfig
{
	public uint id;
	public uint startStepId;
	public QTEType qteType;
	public QTEExec[] startExec;
	public QTEExec[] successExec;
	public QTEExec[] failExec;

	public class QTEExec
	{
		public QTEActionType type;
		public int[] param;
	}
}