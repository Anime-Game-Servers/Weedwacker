using System.Numerics;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    public abstract class SceneEntity : BaseEntity
    {
        internal readonly Scene? Scene;

		public virtual Vector3 Position { get; protected set; }
		public virtual Vector3 Rotation { get; protected set; }
		public Vector3 Speed { get; protected set; }
		internal virtual InteractType InteractType => InteractType.None;
		public LifeState LiveState { get; protected set; }
		public MotionState MotionState { get; protected set; }
		public Dictionary<FightPropType, float> FightProps { get; protected set; }
		internal uint LastMoveSceneTimeMs;
		internal uint LastMoveReliableSeq;

        public bool LockHP;
        internal World? World
        {
            get
            {
                if (Scene == null) return null;
                else return Scene.World;
            }
        }
                protected MotionInfo MotionInfo
        {
            get
            {
                MotionInfo proto = new()
                {
                    Pos = new Shared.Network.Proto.Vector() { X = Position.X, Y = Position.Y, Z = Position.Z },
                    Rot = new Shared.Network.Proto.Vector() { X = Rotation.X, Y = Rotation.Y, Z = Rotation.Z },
                    Speed = new(), //TODO
                    State = MotionState
                };

                return proto;
            }
        }

        internal SceneEntity(Scene? scene)
        {
            Scene = scene;
            MotionState = MotionState.None;
        }


        public virtual bool SetMotionState(MotionState state)
        {
            MotionState = state;
            return true;
        }

        public virtual async Task<float> HealAsync(float amount)
        {
            float curHp = FightProps[FightPropType.FIGHT_PROP_CUR_HP];
            float maxHp = FightProps[FightPropType.FIGHT_PROP_MAX_HP];

            if (curHp >= maxHp)
            {
                return 0f;
            }

            float healed = Math.Min(maxHp - curHp, amount);
            FightProps[FightPropType.FIGHT_PROP_CUR_HP] += healed;
            await Scene.BroadcastPacketAsync(new PacketEntityFightPropUpdateNotify(this, FightPropType.FIGHT_PROP_CUR_HP));

            return healed;
        }

        public virtual async Task DamageAsync(float amount, uint attackerId = 0)
        {
            // Check if the entity has properties.
            if (FightProps == null || !FightProps.ContainsKey(FightPropType.FIGHT_PROP_CUR_HP)) return;

            float curHp = FightProps[FightPropType.FIGHT_PROP_CUR_HP];
            if (!float.IsPositiveInfinity(curHp) || curHp <= amount)
            {
                // Add negative HP to the current HP property.
                FightProps[FightPropType.FIGHT_PROP_CUR_HP] -= amount;
            }

            // Check if dead
            bool isDead = false;
            if (FightProps[FightPropType.FIGHT_PROP_CUR_HP] <= 0f)
            {
                FightProps[FightPropType.FIGHT_PROP_CUR_HP] = 0f;
                isDead = true;
            }

            // Packets
            await Scene.BroadcastPacketAsync(new PacketEntityFightPropUpdateNotify(this, FightPropType.FIGHT_PROP_CUR_HP));

            // Check if dead.
            if (isDead)
                await Scene.KillEntityAsync(this, attackerId);
            // Set state
            LiveState = LifeState.LIFE_DEAD;
        }

        public virtual async Task SetHealthAsync(float newHP)
        {
            // Check if the entity has properties.
            if (!FightProps.ContainsKey(FightPropType.FIGHT_PROP_CUR_HP)
                || !FightProps.ContainsKey(FightPropType.FIGHT_PROP_MAX_HP)) return;

            FightProps[FightPropType.FIGHT_PROP_CUR_HP] = Math.Min(newHP,
                FightProps[FightPropType.FIGHT_PROP_MAX_HP]);

            // Packets
            await Scene.BroadcastPacketAsync(new PacketEntityFightPropUpdateNotify(this, FightPropType.FIGHT_PROP_CUR_HP));

            if (newHP == 0f)
                await OnDeathAsync(default);
        }

        public virtual async Task MoveAsync(EntityMoveInfo moveInfo)
        {
            // Set the position and rotation.
            if (moveInfo.MotionInfo.Pos != null)
                Position = new Vector3(moveInfo.MotionInfo.Pos.X, moveInfo.MotionInfo.Pos.Y, moveInfo.MotionInfo.Pos.Z);
            if (moveInfo.MotionInfo.Rot != null)
                Rotation = new Vector3(moveInfo.MotionInfo.Rot.X, moveInfo.MotionInfo.Rot.Y, moveInfo.MotionInfo.Rot.Z);
        }
        internal virtual async Task OnInteractAsync(Player.Player player, GadgetInteractReq interactReq)
        {

        }
        public virtual async Task OnCreateAsync()
        {

        }

        public virtual async Task OnDeathAsync(uint killerId = default, Shared.Network.Proto.PlayerDieType dieType = Shared.Network.Proto.PlayerDieType.KillByMonster)
        {

        }


        public abstract SceneEntityInfo ToProto();

    }
}
