using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class SceneTransPoint : ConfigScenePoint
{
	public uint maxSpringVolume;
	public uint[] cutsceneList;
	public uint npcId;
	public bool isForbidAvatarRevive;
	public bool isForbidAvatarAutoUseSpring;
	public PointMapVisibility mapVisibility;
	public bool showOnLockedArea;
	public bool disableInteraction;
}
