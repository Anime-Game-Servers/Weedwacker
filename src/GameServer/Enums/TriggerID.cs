﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TriggerID
    {
        None,
        ActivatedDeathEnd,
        ActivatedToNormal,
        Active,
        Activetrigger,
        AimEnd,
        AirAtk,
        AlchemicalBreakOutSkin,
        AlertHitTrigger,
        AngryTrigger,
        Appear,
        Attack,
        AttackTrigger,
        AutoDefendTrigger,
        AwakeAlert,
        Aware,
        AwareTrigger,
        BattleIdleTrigger,
        BeCaptured,
        BeHit,
        BeHitTrigger,
        Blink,
        BlinkOver,
        BlinkOutOfbattle,
        BlockBreak,
        Bloom,
        BombCreateFail,
        BombThrowTrigger,
        BornToClose,
        BornToOpen,
        Break,
        BreakTrigger,
        BurstSkinSet,
        ChargeAtkEnd,
        CrashTrigger,
        CreateBombEnd,
        Crow_Control_Show,
        Crow_Summon_Show_Aim,
        Crow_Summon_Show_NoAim,
        Crow_Talent_C_ExtreAttack,
        CounterAttack,
        DebutTrigger,
        DefendAttackTrigger,
        DevilDash_Skin,
        Dice_Attack,
        Dice_Die,
        Die,
        DieShaderTrigger,
        DieTrigger,
        DisappearTrigger,
        DoSkill,
        Drop,
        ElementalBurst_Skin,
        EndChannelTrigger,
        EndHoldTrigger,
        EndLoopPlusTrigger,
        ExtraAttack_Skin,
        FindHappy,
        Fire,
        FireAttack,
        FireCrackerHit,
        GemStone_Impact,
        GeoOrderSkin_Strong,
        GeoOrderSkin_Weak,
        Go_Enpower,
        GoRushAtk,
        growUp,
        Heal,
        Hide_Avatar_OnRemoved,
        Hit,
        IceSprayEnd,
        Idle,
        LevelEnterBattle,
        LevelUp,
        Mark_1,
        Mark_2,
        Mark_End_1,
        Mark_End_2,
        Mask_TriggerTalent,
        Move,
        NextLoopTrigger,
        NextSkillTrigger,
        NoRushMoveTrigger,
        NonetoStage1,
        NormalAttack,
        NormalAttackOver,
        NormalAttackTrigger,
        NormalToActivated,
        OnHit,
        Open,
        Panda_Attack_Trigger,
        PRIVATE_DoLastSpecialExtra,
        PRIVATE_DoSpecialExtra,
        PRIVATE_ElementalArt_End,
        PRIVATE_ExtraEndCharging,
        PRIVATE_NormalToSneak,
        PRIVATE_SneakToNormal,
        RangedAttack01Glow01Trigger,
        ReachTarget,
        Recover,
        RecoverTrigger,
        Restart,
        RetreatTrigger,
        ReturnToBorn,
        Rotate,
        RunRandom,
        RushAtkStop,
        RushAtkTrigger,
        RushHit,
        Shake,
        Shaking,
        SheathWeaponTrigger,
        ShieldUpEnd,
        ShiledBrokenTrigger,
        Shoot,
        Shot,
        Show,
        Show01,
        Show02,
        Shrink,
        showModel,
        Skill_E_SpecialSkin,
        Skill_E_SpecialToNormalSkin,
        SkillHitTrigger,
        Skin_Strong,
        SkinActive_1,
        SkinActive_2,
        SkinOn,
        SkinReset,
        SkinSet,
        SkinTrigger,
        Slow,
        SmashEnd,
        Sprint_Skin,
        SPRushPrepareTrigger,
        Stage1toNone,
        Start,
        StartChannelTrigger,
        StealthOff,
        StealthOn,
        Stop,
        StopSupportAtk,
        SupportAttackExit,
        SupportAttackExit2,
        SwipeTrigger,
        Switch,
        TransformTrigger,
        Trick,
        Trigger_Burst,
        Trigger_Hit,  
        TriggerAttack,
        UnActive,
        WakeUpTrigger,
        WalkToSearch,
        WeakStart,
        WeakStartTrigger,
        WeakTrigger,
        WindHit,
        WildSlamLoopEndTrigger,
        Wilt,
    }
}
