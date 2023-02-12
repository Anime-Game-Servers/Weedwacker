using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DraftExcelConfig
{
	public uint id;
	public DraftTransferConfig[] transferConfig;
	public uint sceneId;
	public DraftExecType exec;
	public DraftExecSubType execSubType;
	public uint param;
	public bool enableMp;
	public bool isNeedAllAgree;
	public uint confirmCountDown;
	public uint minPlayerCount;
	public bool isNeedTwiceConfirm;
	public uint twiceConfirmCountDown;
	public bool isExecWhenCountDownOver;

	public class DraftTransferConfig
	{
		public uint group_id;
		public uint config_id;
	}
}