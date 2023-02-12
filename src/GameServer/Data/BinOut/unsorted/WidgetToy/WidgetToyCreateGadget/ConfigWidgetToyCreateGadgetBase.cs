using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetToyCreateGadgetBase : ConfigBaseWidgetToy
{
	public uint gadgetId;
	public bool isSetCamera;
	public float setCameraAngle;
	public CreateSeverGadgetOpType doBagType;
}