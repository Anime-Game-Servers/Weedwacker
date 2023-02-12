using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigFormulaicMove : ConfigMove
    {
		public UGCTimeControlType timeControl;
		public UGCFormulaType formulaType;
		public UGCMoveType moveMode;
		public float[] offTime;
		public bool automaticMove;
		public UGCAxialType polar;
		public float[] angleSection;
		public float angleStep;
		public bool isClockWise;
		public float angleSpeed;
		public float[] period;
		public Vector[] route;
	}
}
