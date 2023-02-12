using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCameraSplineCameraPath : ConfigCameraSplineBasePath
{
	public ConfigCameraSplineBasePoint[] pathPoints;
	public ConfigAnimationCurve fovCurve;
}