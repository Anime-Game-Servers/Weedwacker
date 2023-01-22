using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems
{
    [BsonKnownTypes(typeof(None), typeof(Fire), typeof(Water), typeof(Wind), typeof(Ice), typeof(Rock), typeof(Electric), typeof(Grass), typeof(Default), typeof(Frozen), typeof(AntiFire))]
    public class ElementType
    {      
        public float MaxEnergy = 0;
        public float CurEnergy = 0;
        [BsonIgnore]
        public virtual Enums.ElementType Type => Enums.ElementType.None;
        [BsonIgnore]
        public virtual FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        [BsonIgnore]
        public virtual FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
        [BsonIgnore]
        public virtual int DepotValue => 0;
    }

    public class None : ElementType
    {
    }

    public class Fire : ElementType
    {
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
        public override int DepotValue => 2;
        public override Enums.ElementType Type => Enums.ElementType.Fire;

    }

    public class Water : ElementType
    {
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_WATER_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_WATER_ENERGY;
        public override int DepotValue => 3;
        public override Enums.ElementType Type => Enums.ElementType.Water;
    }

    public class Wind : ElementType
    {
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_WIND_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_WIND_ENERGY;
        public override int DepotValue => 4;
        public override Enums.ElementType Type => Enums.ElementType.Wind;
    }

    public class Ice : ElementType
    {
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_ICE_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_ICE_ENERGY;
        public override int DepotValue => 5;
        public override Enums.ElementType Type => Enums.ElementType.Ice;
    }

    public class Rock : ElementType
    {
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_ROCK_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_ROCK_ENERGY;
        public override int DepotValue => 6;
        public override Enums.ElementType Type => Enums.ElementType.Rock;
    }

    public class Electric : ElementType
    {
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_ELEC_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_ELEC_ENERGY;
        public override int DepotValue => 7;
        public override Enums.ElementType Type => Enums.ElementType.Electric;
    }

    public class Grass : ElementType
    {
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_GRASS_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_GRASS_ENERGY;
        public override int DepotValue => 8;
        public override Enums.ElementType Type => Enums.ElementType.Grass;
    }

    public class Default : ElementType
    {
        public override Enums.ElementType Type => Enums.ElementType.Default;
    }

    public class Frozen : ElementType
    {
        public override Enums.ElementType Type => Enums.ElementType.Frozen;
        public override FightProperty CurEnergyProp => FightProperty.FIGHT_PROP_CUR_ICE_ENERGY;
        public override FightProperty MaxEnergyProp => FightProperty.FIGHT_PROP_MAX_ICE_ENERGY;
    }

    public class AntiFire : ElementType
    {
        public override Enums.ElementType Type => Enums.ElementType.AntiFire;
    }
}