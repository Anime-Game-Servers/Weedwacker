using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.World
{
	internal abstract class BaseGadgetEntity : SceneEntity
	{
		public GadgetData Data => GameData.GadgetDataMap[GadgetId];
		public uint GadgetId { get; protected set; }

		public int DraftId { get; protected set; }

		/// <summary>
		/// Use only this function to instantiate gadgets
		/// This function will return the correct derived type based on the Script SpawnInfo
		/// and the info in various excels
		/// </summary>
		/// <returns>A Gadget that inherits from the BaseGadgetEntity class</returns>
		public static async Task<BaseGadgetEntity?> CreateGadgetAsync(Scene? scene, Player.Player player, SceneGroup.Gadget spawnInfo)
		{
			uint gadgetId = spawnInfo.gadget_id;
			GadgetData excel = GameData.GadgetDataMap[gadgetId];
			//TODO
			switch (excel.type)
			{
				case EntityType.Chest:
					if (spawnInfo.is_blossom_chest == true)
					{
						return new BlossomChestEntity(scene, spawnInfo);
					}
					else if(spawnInfo.boss_chest != null)
					{
						return new BossChestEntity(scene, spawnInfo);
					}
					else
					{
						return new ChestEntity(scene, spawnInfo);
					}
				case EntityType.Platform:
					return new PlatformEntity(scene, spawnInfo);
				default:
					Logger.DebugWriteWarningLine($"Unhandled Script Gadget entity type: {excel.type}, gadgetId: {gadgetId}");
					return null;
			}
		}
		protected BaseGadgetEntity(Scene scene, SceneGroup.Gadget spawnInfo) : base(scene)
		{
			GadgetId = spawnInfo.gadget_id;
			EntityId = scene.World.GetNextEntityId(EntityIdType.GADGET);
            Position = spawnInfo.pos;
			Rotation = spawnInfo.rot;
            AbilityManager = new GadgetAbilityManager(this);
		}

		protected BaseGadgetEntity(Scene scene, uint gadgetId) : base(scene)
		{
			GadgetId = gadgetId;
			EntityId = scene.World.GetNextEntityId(EntityIdType.GADGET);
			AbilityManager = new GadgetAbilityManager(this);
		}

		public override SceneEntityInfo ToProto()
		{
			EntityAuthorityInfo authority = new EntityAuthorityInfo()
			{
				AbilityInfo = new AbilitySyncStateInfo(),
				RendererChangedInfo = new EntityRendererChangedInfo(),
				AiInfo = new SceneEntityAiInfo() { IsAiOpen = true, BornPos = new Vector() { X = Position.X, Y = Position.Y, Z = Position.Z }, },
				BornPos = new Vector() { X = Position.X, Y = Position.Y, Z = Position.Z },
            };

			SceneEntityInfo entityInfo = new SceneEntityInfo()
			{
				EntityId = EntityId,
				EntityType = ProtEntityType.Gadget,
				MotionInfo = MotionInfo,
				EntityClientData = new(),
				EntityAuthorityInfo = authority,
				LifeState = (uint)LifeState.LIFE_ALIVE
			};
			entityInfo.AnimatorParaList.Add(new AnimatorParameterValueInfoPair());

			PropPair pair = new()
			{
				Type = (uint)PlayerProperty.PROP_LEVEL,
				PropValue = new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Val = 1, Ival = 1 }
			};
			entityInfo.PropList.Add(pair);

			if (FightProps != null)
			{
				foreach (var entry in FightProps)
				{
					FightPropPair fightProp = new() { PropType = (uint)entry.Key, PropValue = entry.Value };
					entityInfo.FightPropList.Add(fightProp);
				}
			}

			SceneGadgetInfo gadgetInfo = new()
			{
				GadgetId = GadgetId,
				GadgetState = (uint)LiveState,
				IsEnableInteract = true,
				AuthorityPeerId = Scene.World.HostPeerId,
				DraftId = (uint)DraftId,
			};

			entityInfo.Gadget = gadgetInfo;

			return entityInfo;
		}
	}
}
