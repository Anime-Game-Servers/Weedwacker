using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class SceneVehicleSummonPoint : ConfigScenePoint
{
	public VehicleType vehicleType;
	public uint vehicleGadgetIdRawNum;
	public Vector[] bornPointList;
	public Vector[] bornRotateList;
	public float vehicleRadiusRawNum;
	public string titleTextID;
	public SceneVehicleSummonPointMapMarkType mapMarkType;
}
