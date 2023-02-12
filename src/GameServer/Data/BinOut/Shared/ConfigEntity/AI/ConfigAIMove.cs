using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIMove
{
	public bool enable;
	public MoveCategoryAI moveCategory;
	public bool useNavMesh;
	public string navMeshAgentName;
	public float almostReachedDistanceWalk;
	public float almostReachedDistanceRun;
	public ConfigAISnakelikeMove snakelikeMoveSetting;

	public class ConfigAISnakelikeMove
	{
		public float minCurvature;
		public float maxCurvatrue;
		public float minSegmentDistance;
		public float segmentDistance;
		public int segmentCount;
	}
}