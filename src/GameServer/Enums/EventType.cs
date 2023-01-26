﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventType
    {
        EVENT_NONE = 0,
        EVENT_ANY_MONSTER_DIE = 1,
        EVENT_ANY_GADGET_DIE = 2,
        EVENT_VARIABLE_CHANGE = 3,
        EVENT_ENTER_REGION = 4,
        EVENT_LEAVE_REGION = 5,
        EVENT_GADGET_CREATE = 6,
        EVENT_GADGET_STATE_CHANGE = 7,
        EVENT_DUNGEON_SETTLE = 8,
        EVENT_SELECT_OPTION = 9,
        EVENT_CLIENT_EXECUTE = 10,
        EVENT_ANY_MONSTER_LIVE = 11,
        EVENT_SPECIFIC_MONSTER_HP_CHANGE = 12,
        EVENT_CITY_LEVELUP_UNLOCK_DUNGEON_ENTRY = 13,
        EVENT_DUNGEON_BROADCAST_ONTIMER = 14,
        EVENT_TIMER_EVENT = 15,
        EVENT_CHALLENGE_SUCCESS = 16,
        EVENT_CHALLENGE_FAIL = 17,
        EVENT_SEAL_BATTLE_BEGIN = 18,
        EVENT_SEAL_BATTLE_END = 19,
        EVENT_GATHER = 20,
        EVENT_QUEST_FINISH = 21,
        EVENT_MONSTER_BATTLE = 22,
        EVENT_CITY_LEVELUP = 23,
        EVENT_CUTSCENE_END = 24,
        EVENT_AVATAR_NEAR_PLATFORM = 25,
        EVENT_PLATFORM_REACH_POINT = 26,
        EVENT_UNLOCK_TRANS_POINT = 27,
        EVENT_QUEST_START = 28,
        EVENT_GROUP_LOAD = 29,
        EVENT_GROUP_WILL_UNLOAD = 30,
        EVENT_GROUP_WILL_REFRESH = 31,
        EVENT_GROUP_REFRESH = 32,
        EVENT_DUNGEON_REWARD_GET = 33,
        EVENT_SPECIFIC_GADGET_HP_CHANGE = 34,
        EVENT_MONSTER_TIDE_OVER = 35,
        EVENT_MONSTER_TIDE_CREATE = 36,
        EVENT_MONSTER_TIDE_DIE = 37,
        EVENT_SEALAMP_PHASE_CHANGE = 38,
        EVENT_BLOSSOM_PROGRESS_FINISH = 39,
        EVENT_BLOSSOM_CHEST_DIE = 40,
        EVENT_GADGET_PLAY_START = 41,
        EVENT_GADGET_PLAY_START_CD = 42,
        EVENT_GADGET_PLAY_STOP = 43,
        EVENT_GADGET_LUA_NOTIFY = 44,
        EVENT_MP_PLAY_PREPARE = 45,
        EVENT_MP_PLAY_BATTLE = 46,
        EVENT_MP_PLAY_PREPARE_INTERRUPT = 47,
        EVENT_SELECT_DIFFICULTY = 48,
        EVENT_SCENE_MP_PLAY_BATTLE_STATE = 49,
        EVENT_SCENE_MP_PLAY_BATTLE_STAGE_CHANGE = 50,
        EVENT_SCENE_MP_PLAY_BATTLE_RESULT = 51,
        EVENT_SEAL_BATTLE_PROGRESS_DECREASE = 52,
        EVENT_GENERAL_REWARD_DIE = 53,
        EVENT_SCENE_MP_PLAY_BATTLE_INTERRUPT = 54,
        EVENT_MONSTER_DIE_BEFORE_LEAVE_SCENE = 55,
        EVENT_SCENE_MP_PLAY_OPEN = 56,
        EVENT_OFFERING_LEVELUP = 57,
        EVENT_DUNGEON_REVIVE = 58,
        EVENT_SCENE_MP_PLAY_ALL_AVATAR_DIE = 59,
        EVENT_DUNGEON_ALL_AVATAR_DIE = 60,
        EVENT_GENERAL_REWARD_TAKEN = 61,
        EVENT_PLATFORM_REACH_ARRAYPOINT = 62,
        EVENT_SCENE_MULTISTAGE_PLAY_STAGE_END = 63,
        EVENT_SCENE_MULTISTAGE_PLAY_END_STAGE_REQ = 64,
        EVENT_MECHANICUS_PICKED_CARD = 65,
        EVENT_POOL_MONSTER_TIDE_OVER = 66,
        EVENT_POOL_MONSTER_TIDE_CREATE = 67,
        EVENT_POOL_MONSTER_TIDE_DIE = 68,
        EVENT_DUNGEON_AVATAR_SLIP_DIE = 69,
        EVENT_GALLERY_START = 70,
        EVENT_GALLERY_STOP = 71,
        EVENT_TIME_AXIS_PASS = 72,
        EVENT_FLEUR_FAIR_DUNGEON_ALL_PLAYER_ENTER = 73,
        EVENT_GADGETTALK_DONE = 74,
        EVENT_SET_GAME_TIME = 75,
        EVENT_HIDE_AND_SEEK_PLAYER_QUIT = 76,
        EVENT_AVATAR_DIE = 77,
        EVENT_SCENE_MULTISTAGE_PLAY_STAGE_START = 78,
        EVENT_GALLERY_PROGRESS_PASS = 79,
        EVENT_GALLERY_PROGRESS_EMPTY = 80,
        EVENT_GALLERY_PROGRESS_FULL = 81,
        EVENT_HUNTING_FINISH_FINAL = 82,
        EVENT_USE_WIDGET_TOY_FOX_CAMERA = 83,
        EVENT_LUNA_RITE_SACRIFICE = 84,
        EVENT_SUMO_SWITCH_TEAM_EVENT = 85,
        EVENT_FISHING_START = 86,
        EVENT_FISHING_STOP = 87,
        EVENT_FISHING_QTE_FINISH = 88,
        EVENT_FISHING_TIMEOUT_FLEE = 89,
        EVENT_ROGUE_CELL_STATE_CHANGE = 90,
        EVENT_ROGUE_CELL_CONSTRUCT = 91,
        EVENT_ROGUE_CELL_FINISH_SELECT_CARD = 92,
        EVENT_ANY_MONSTER_CAPTURE = 93,
        EVENT_ACTIVITY_INTERACT_GADGET = 94,
        EVENT_CHALLENGE_PAUSE = 95,
        EVENT_LEVEL_TAG_CHANGE = 96,
        EVENT_CUSTOM_DUNGEON_START = 97,
        EVENT_CUSTOM_DUNGEON_RESTART = 98,
        EVENT_CUSTOM_DUNGEON_REACTIVE = 99,
        EVENT_CUSTOM_DUNGEON_OUT_STUCK = 100,
        EVENT_CUSTOM_DUNGEON_EXIT_TRY = 101,
        EVENT_CUSTOM_DUNGEON_OFFICIAL_RESTART = 102,
        EVENT_ANY_MONSTER_CAPTURE_AND_DISAPPEAR = 103,
        EVENT_MICHIAE_INTERACT = 104,
        EVENT_SELECT_UIINTERACT = 105,
        EVENT_LUA_NOTIFY = 106,
        EVENT_PHOTO_FINISH = 107,
        EVENT_IRODORI_MASTER_READY = 108,
        EVENT_ROGUE_START_FIGHT = 109,
        EVENT_ROGUE_CREAGE_FIGHT_GADGET = 110,
        EVENT_ROGUE_CREAGE_REPAIR_GADGET = 111,
        EVENT_ROGUE_OPEN_ACCESS = 112,
        EVENT_GADGET_GIVING_FINISHED = 113,
        EVENT_OBSERVATION_POINT_NOTIFY = 114,
        EVENT_GADGET_GIVING_TAKEBACK = 115,
        EVENT_ECHO_SHELL_INTERACT = 116,
        EVENT_PLATFORM_ARRIVAL = 2701,
        EVENT_PLAYER_BACK_GALLERY_REVIVE_POINT = 2800,
        EVENT_GALLERY_CANNOT_START_AFTER_COUNTDOWN = 2801,
    }
}
