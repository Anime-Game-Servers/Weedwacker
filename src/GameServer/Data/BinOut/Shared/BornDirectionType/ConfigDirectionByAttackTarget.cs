
namespace Weedwacker.GameServer.Data;

public class ConfigDirectionByAttackTarget : ConfigBornDirectionType
{
	public float speedForPredictive;
	public DirectionTarDistanceScatter scatter;

	public class DirectionTarDistanceScatter
	{
		public float maxDistance;
		public float maxScatterAngle;
		public float centerRote;
		public float randomRote;
	}
}