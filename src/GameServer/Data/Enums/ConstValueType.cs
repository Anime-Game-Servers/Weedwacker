
namespace Weedwacker.GameServer.Data.Enums;

public enum ConstValueType : int
{
	CONST_VALUE_GAME_TIME_PER_DAY = 1,
	CONST_VALUE_INIT_GAME_TIME = 2,
	CONST_VALUE_INIT_TEAM_AVATAR = 3,
	CONST_VALUE_CHANGE_AVATAR_CD = 4,
	CONST_VALUE_AVATAR_HP_RECOVER = 5,
	CONST_VALUE_DASH_COST_STAMINA = 6,
	CONST_VALUE_CLIMB_COST_STAMINA = 7,
	CONST_VALUE_CLIMB_JUMP_COST_STAMINA = 8,
	CONST_VALUE_SWIM_COST_STAMINA = 9,
	CONST_VALUE_SWIM_DASH_COST_STAMINA = 10,
	CONST_VALUE_FLY_COST_STAMINA = 11,
	CONST_VALUE_FALL_HURT = 12,
	CONST_VALUE_PACK_MAX_WEIGHT = 13,
	CONST_VALUE_DEPOT_MAX_WEIGHT = 14,
	CONST_VALUE_KILL_MONSTER_EXP = 15,
	CONST_VALUE_PLAYER_WORLD_SCENE_ID = 16,
	CONST_VALUE_PLAYER_PICKUP_RANGE = 17,
	CONST_VALUE_ITEM_STACK_MAX = 18,
	CONST_VALUE_AVATAR_DIE_MAX_TIME = 19,
	CONST_VALUE_DEFENSE_RESIST_RATIO = 20,
	CONST_VALUE_CRITICAL_LIMIT = 21,
	CONST_VALUE_BLOCK_REFRESH_PARAM = 22,
	CONST_VALUE_DUNGEON_KEEP_TIME = 23,
	CONST_VALUE_ADSORBATE_PICKUP_RANGE = 24,
	CONST_VALUE_ADSORBATE_STAY_TIME = 25,
	CONST_VALUE_ELEMENT_OVERLOAD_MAX = 26,
	CONST_VALUE_ELEMENT_OVERLOAD_REDUCE = 27,
	CONST_VALUE_PURGE_DECREMENT = 28,
	CONST_VALUE_WATER_FIRE_DECRATE = 29,
	CONST_VALUE_ICE_FIRE_DECRATE = 30,
	CONST_VALUE_EFFECT_RESIST_LEVEL_FIX = 31,
	CONST_VALUE_DUNGEON_REVIVE_WAIT_TIME = 32,
	CONST_VALUE_FOOD_WEAPON_EXP_DISCOUNT_PARAM = 33,
	CONST_VALUE_FOOD_RELIQUARY_EXP_DISCOUNT_PARAM = 34,
	CONST_VALUE_DAMAGE_LEVEL_FIX = 35,
	CONST_VALUE_DUNGEON_CANCEL_WAIT_TIME = 36,
	CONST_VALUE_ENDURE_LEVEL_FIX = 37,
	CONST_VALUE_SECRET_CHEST_DAY_LIMIT = 38,
	CONST_VALUE_HURT_REVIVE_HP_PERCENT = 39,
	CONST_VALUE_NO_HURT_DIE_SUB_HP_PERCENT = 40,
	CONST_VALUE_SPRING_RECOVER_TIME = 41,
	CONST_VALUE_SPRING_RECOVER_PARAM = 42,
	CONST_VALUE_SPRING_AUTO_RECOVER_DELAY = 43,
	CONST_VALUE_BACK_AVATAR_AUTO_RECOVER_PARAM = 44,
	CONST_VALUE_STAMINA_LIMIT = 45,
	CONST_VALUE_BORED_LIMIT = 46,
	CONST_VALUE_BORED_CREATE_MONSTER = 47,
	CONST_VALUE_SKILL_CD_MIN_PRESERVE_TIME = 48,
	CONST_VALUE_TALENT_POINT_LIMIT = 49,
	CONST_VALUE_ELEMENTREACTION_AREALEVELDELTA_LIMIT = 50,
	CONST_VALUE_BORED_ENABLE_QUEST_ID = 51,
	CONST_VALUE_EXTRA_STAMINA_LIMIT = 52,
	CONST_VALUE_MODIFIER_MIN_PRESERVE_TIME = 53,
	CONST_VALUE_NICKNAME_MAX_LENGTH = 54,
	CONST_VALUE_AREA_CHECK_CD = 55,
	CONST_VALUE_PORTAL_TRANSPORT_TIME = 56,
	CONST_VALUE_ENV_ANIMAL_REFRESH = 58,
	CONST_VALUE_ENV_ANIMAL_GROUP = 59,
	CONST_VALUE_BUSH_DROP = 61,
	CONST_VALUE_COOK_AUTO_QUALITY = 62,
	CONST_VALUE_KILL_DROP_EXP_CONFIG = 63,
	CONST_VALUE_AVATAR_MAX_PROMOTE_LEVEL = 64,
	CONST_VALUE_VIOLIN_LIST = 65,
	CONST_VALUE_CROUCH_ROLL_COST_STAMINA = 66,
	CONST_VALUE_STAMINA_RECOVER_WAIT_TIME = 67,
	CONST_VALUE_FIREWORM_ESCAPE_PARMA = 68,
	CONST_VALUE_TIMEOUT_SECOND_PARMA = 69,
	CONST_VALUE_TIMEOUT_COUND_PARMA = 70,
	CONST_VALUE_DASH_BS_COST_STAMINA = 71,
	CONST_VALUE_MAIL_MAX_NUM = 72,
	CONST_VALUE_RECORD_MONSTER_DIS = 73,
	CONST_VALUE_RECORD_MONSTER_ANGLE = 74,
	CONST_VALUE_COMPOUND_QUEUE_MAX_COUNT = 75,
	CONST_VALUE_WEAPON_AUTO_HIDE_TIME = 76,
	CONST_VALUE_WEAPON_LEVELUP_COST = 77,
	CONST_VALUE_RELIQUARY_LEVELUP_COST = 78,
	CONST_VALUE_CLIMB_MIN_STAMINA = 79,
	CONST_VALUE_ELEMENT_SHOW_DISTANCE = 80,
	CONST_VALUE_WALK_TO_SWIM_ADD_STAMINA = 81,
	CONST_VALUE_QUESTGUIDE_SHOW_DISTANCE = 82,
	CONST_VALUE_LIMIT_QUALITY_ONDROP = 83,
	CONST_VALUE_STEER_MIN_ANGLE = 84,
	CONST_VALUE_MAP_WARNING_DISTANCE = 85,
	CONST_VALUE_MAP_WARNING_INTERVAL = 86,
	CONST_VALUE_AREA_LEVEL_WARNING_THR = 87,
	CONST_VALUE_SUPERCONDUCTOR_DURABILITY = 88,
	CONST_VALUE_SWIRL_PARAM = 89,
	CONST_VALUE_IS_MP_OPEN = 91,
	CONST_VALUE_CRASH_PARAM = 92,
	CONST_VALUE_ELEMENT_MASTERY_PARAM = 93,
	CONST_VALUE_DAILY_TASK_PARAM = 94,
	CONST_VALUE_NEXT_DAY = 95,
	CONST_VALUE_RAND_TASK_REFRESH_PARAM = 96,
	CONST_VALUE_RAND_TASK_POS_PARAM = 97,
	CONST_VALUE_ENERGY_RECHANGE_RATIO = 98,
	CONST_VALUE_DEFAULT_WORLD_ID = 99,
	CONST_VALUE_RAND_TASK_QEST_PARAM = 100,
	CONST_VALUE_RAND_TASK_COMP_PARAM = 101,
	CONST_VALUE_EXPEDITION_INIT_LIMIT = 102,
	CONST_VALUE_WORLD_LEVEL_FORMULA = 103,
	CONST_VALUE_SWIM_DASH_COST_STAMINA_PER_SECOND = 104,
	CONST_VALUE_RAND_TASK_POINT_PARAM = 105,
	CONST_VALUE_WEATHER_INTERVAL = 106,
	CONST_VALUE_DUNGEON_DAILY_ITEM = 107,
	CONST_VALUE_DUNGEON_WEEKLY_ITEM = 108,
	CONST_VALUE_AVATAR_COMBAT_FORCE_PARAM = 109,
	CONST_VALUE_PLAYER_COMBAT_FORCE_PARAM = 110,
	CONST_VALUE_CORE_PROUD_SKILL_MAX_LEVEL = 111,
	CONST_VALUE_INHERENT_PROUD_SKILL_MAX_LEVEL = 112,
	CONST_VALUE_ACTIVE_SKILL_MAX_LEVEL = 113,
	CONST_VALUE_COOK_QTE_PERFECT_RANGE_VALUE = 114,
	CONST_VALUE_TEAMNAME_MAX_LENGTH = 115,
	CONST_VALUE_DUNGEON_OEPN_QUEST = 116,
	CONST_VALUE_MP_CHAT_PARAM = 117,
	CONST_VALUE_CLIMB_COST_STAMINA_FORMULA = 118,
	CONST_VALUE_CLIMB_JUMP_COST_STAMINA_FORMULA = 119,
	CONST_VALUE_DUNGEON_CANDIDATE_INVITE_VAILD_TIME_SEC = 120,
	CONST_VALUE_SET_STRUGGLE_LEVEL_DIFFERENCE_THRESHOLD = 121,
	CONST_VALUE_DUNGEON_INVITE_NEED_TRANS_DISTANCE = 122,
	CONST_VALUE_PLAYER_LEVEL_REWARD_UNLOCK_PREVIEW_LIMIT = 123,
	CONST_VALUE_DROP_SUBFIELD_PARAM = 124,
	CONST_VALUE_NPC_CONFLICT_DISTANCE = 125,
	CONST_VALUE_SEA_LAMP_ACTIVITY = 126,
	CONST_VALUE_ACTIVITY = 127,
	CONST_VALUE_AVATAR_UPGRADE_COST_RATIO = 128,
	CONST_VALUE_SEA_LAMP_PRAY_URL = 129,
	CONST_VALUE_SEA_LAMP_ACTIVITY2 = 130,
	CONST_VALUE_DAILY_TASK_PARAM2 = 131,
	CONST_VALUE_SEA_LAMP_QUEST = 132,
	CONST_VALUE_DAILY_TASK_OPEN_CUSTOM_POOL = 133,
	CONST_VALUE_RESIN_PARAM = 134,
	CONST_VALUE_RESIN_BUYING_COST = 136,
	CONST_VALUE_TOWER_DAILY_MAIL_ID = 138,
	CONST_VALUE_TOWER_MONTHLY_MAIL_ID = 139,
	CONST_VALUE_TOWER_OVERFLOW_FIRST_PASS = 140,
	CONST_VALUE_LIMIT_REGION_PATH = 141,
	CONST_VALUE_SEA_LAMP_ACTIVITY3 = 142,
	CONST_VALUE_DEFAULT_MATERIAL_GADGET_ID = 144,
	CONST_VALUE_DISTANCE_CHECK = 145,
	CONST_VALUE_PROFICIENT_PLAYER_CHILD_QUEST = 146,
	CONST_VALUE_GACHA_GUARANTEE_START_COEFFICIENT = 147,
	CONST_VALUE_GACHA_GUARANTEE_INCREASE_COEFFICIENT = 148,
	CONST_VALUE_GACHA_DYNAMIC_UP_BASE = 149,
	CONST_VALUE_QUEST_TRIAL_AVATAR_COMBAT_FORCE_CONVERT_RATIO = 150,
	CONST_VALUE_OUTPUT_LIMIT_SWITCH = 151,
	CONST_VALUE_OUTPUT_CONTROL_SWITCH = 152,
	CONST_VALUE_FROMBACK_LIMITTIME = 153,
	CONST_VALUE_FROMBACK_LIMITRATIO = 154,
	CONST_VALUE_RECONNECT_DELAY_BASE = 155,
	CONST_VALUE_FROMBACK_RECONNECT_DURATION = 156,
	CONST_VALUE_FORCE_RECONNECT_DURATION = 157,
	CONST_VALUE_SOCIAL_CONFIG = 158,
	CONST_VALUE_BATTLE_PASS_MISSION_REFRESH = 159,
	CONST_VALUE_PRODUCT_PARAM = 160,
	CONST_VALUE_SATIATION_PARAM = 161,
	CONST_VALUE_MALL_LIMITTIMEPT_SHOWTIME = 162,
	CONST_VALUE_GAGDET_CREATION_LIMIT_DROP_TAG = 163,
	CONST_VALUE_LOADING_LIGHT_BG_PERIOD = 164,
	CONST_VALUE_DUNGEON_LEVEL_LIMIT = 165,
	CONST_VALUE_MOVE_SPEED_CHECK_PARAM = 166,
	CONST_VALUE_DISCONNECTHINT_TIMEOUT_SECONDS = 167,
	CONST_VALUE_BAG_OVERFLOW_MAIL_ID = 168,
	CONST_VALUE_ACTIVITY_CRUCIBLE_QUEST_ID = 169,
	CONST_VALUE_MP_PLAY_CONFIG = 170,
	CONST_VALUE_REBATE_MAIL_ID = 172,
	CONST_VALUE_CRUCIBLE_CONFIG = 173,
	CONST_VALUE_DEFAULT_FLYCLOAK_CONFIG = 174,
	CONST_VALUE_DEFAULT_NAME_CARD_ID = 175,
	CONST_VALUE_MATERIAL_ITEM_LIMIT = 176,
	CONST_VALUE_RELIQUARY_ITEM_LIMIT = 177,
	CONST_VALUE_WEAPON_ITEM_LIMIT = 178,
	CONST_VALUE_BATTLEPASS_VIDEO_CONFIG = 180,
	CONST_VALUE_MATERIAL_DESTROY_RETURN_MATERIAL_LIMIT = 181,
	CONST_VALUE_BATTLE_PASS_ITEM_USE_CONFIG = 182,
	CONST_VALUE_ACTIVITY_NEWBEE_ID = 183,
	CONST_VALUE_PERSONAL_LINE_CONFIG = 184,
	CONST_VALUE_RTT_LOW = 185,
	CONST_VALUE_RTT_MID = 186,
	CONST_VALUE_RTT_HIGH = 187,
	CONST_VALUE_RTT_REFRESH_TIME = 188,
	CONST_VALUE_SPEECH_BUBBLE_DEFAULT_DURATION = 189,
	CONST_VALUE_SPEECH_BUBBLE_EXTRA_DURATION = 190,
	CONST_VALUE_FORGE_POINT_DAY_LIMIT = 191,
	CONST_VALUE_FIRST_SHARE_REWARD = 192,
	CONST_VALUE_POINT_CARD_RECHARGE = 193,
	CONST_VALUE_EXPLORE = 194,
	CONST_VALUE_MAP_MARK_MAX_LENGTH = 195,
	CONST_VALUE_GUIDE_RATING_CHAPTERID = 196,
	CONST_VALUE_PS4_TROPHY_SWITCH = 197,
	CONST_VALUE_ASTER_MIDDLE_RECOVER = 198,
	CONST_VALUE_ASTER_MIDDLE_NPC_TALK_ID = 199,
	CONST_VALUE_HUNTING_REVISE_LEVEL = 200,
	CONST_VALUE_REMINDER_INTERRUPT_SHOW_DELAY = 201,
	CONST_VALUE_UPGRADE_WEAPON_RETURN_MATERIAL_ID = 202,
	CONST_VALUE_CITY_REPUTATION_PARAM = 203,
	CONST_VALUE_REPORT_PARAM = 204,
	CONST_VALUE_DRAGON_SPINE_CONFIG = 205,
	CONST_VALUE_DUNGEON_RESTART_INVITE_VAILD_TIME_SEC = 206,
	CONST_VALUE_REUNION_PARAM = 207,
	CONST_VALUE_TOWER_RESET = 208,
	CONST_VALUE_SNOW_MOUNTAIN_ROUTINE = 209,
	CONST_VALUE_ELEMENT_TRIAL_MARK_SHOW_LEVEL_LIMIT = 210,
	CONST_VALUE_ANTI_HARASSMENT_CONFIG = 211,
	CONST_VALUE_DRAGON_SPINE_MP_PLAY_CONFIG = 212,
	CONST_VALUE_DIE_INVINCIBLE_CONFIG = 213,
	CONST_VALUE_GRASS_TILE_ELEMENT_REACTION_POS_OFFSET = 214,
	CONST_VALUE_ASK_ADD_FRIEND_FREQUENCY_CONFIG = 215,
	CONST_VALUE_BLESSING_CONFIG = 216,
	CONST_VALUE_MIRACLE_RING_CD = 217,
	CONST_VALUE_MIRACLE_RING_DROP_COUNT = 218,
	CONST_VALUE_MIRACLE_RING_DELIVER_VALUE = 219,
	CONST_VALUE_MIRACLE_RING_RANDOM_DROP_PROB = 220,
	CONST_VALUE_MIRACLE_RING_ITEM_ADD_PACK = 221,
	CONST_VALUE_MP_REWARD_RESERVED_TIME_CONFIG = 222,
	CONST_VALUE_CHAT_PARAM = 223,
	CONST_VALUE_ACTIVITY_EXPEDITION_DAILY_REFRESH_PATH_LIMIT = 224,
	CONST_VALUE_ACTIVITY_EXPEDITION_DAILY_COUNT_LIMIT = 225,
	CONST_VALUE_ACTIVITY_EXPEDITION_SUPER_ELEM_COEF = 226,
	CONST_VALUE_ACTIVITY_MONSTER_BANNER_DRAKE_PRIMO_ROCK = 227,
	CONST_VALUE_SHOP_OUTPUT_SWITCH = 228,
	CONST_VALUE_MECHANICUS_ROTATION_PARAM = 229,
	CONST_VALUE_MECHANICUS_CARD_PARAM = 230,
	CONST_VALUE_FORCE_DRAG_BACK_PARAM = 231,
	CONST_VALUE_ACTIVITY_EXPEDITION_CONTENT_DURATION = 232,
	CONST_VALUE_ACTIVITY_EXPEDITION_CHALLENGE_HINT_CD = 233,
	CONST_VALUE_MUIP_MAIL_REWARD_LIMIT = 234,
	CONST_VALUE_ARENA_CHALLENGE_REWARD_WORKTOP = 235,
	CONST_VALUE_ACTIVITY_WATER_SPRITE_PARA = 236,
	CONST_VALUE_WORLD_LEVEL_ADJUST = 237,
	CONST_VALUE_NECHANICUS_OPEN_QUESTID = 238,
	CONST_VALUE_ACTIVITY_WATER_SPRITE_PARA_SECONDPART = 239,
	CONST_VALUE_COOP_QUESTID_INTERVAL = 240,
	CONST_VALUE_HIT_TREE_DROP_PARAM = 241,
	CONST_VALUE_HIT_TREE_DROP_PROB = 243,
	CONST_VALUE_DEFAULT_HOME_WORLD_ID = 244,
	CONST_VALUE_HOME_SPEECHBUBBLE_DEFAULT_DELAY = 245,
	CONST_VALUE_HOME_SPEECHBUBBLE_DEFAULT_INTERVAL = 246,
	CONST_VALUE_HOME_SPEECHBUBBLE_PRIORITY = 247,
	CONST_VALUE_HOME_GREET_DIST_MIN = 248,
	CONST_VALUE_HOME_GREET_DIST_MAX = 249,
	CONST_VALUE_HOME_GREET_ANGLE_MAX = 250,
	CONST_VALUE_HOME_GREET_TURN_ANGLE = 251,
	CONST_VALUE_HOME_GREET_TURN_DURATION = 252,
	CONST_VALUE_MULTI_PLAY_FETTER_EXP_RATIO = 253,
	CONST_VALUE_ROOM_MINIMAP_DEFAULT_SCALE = 254,
	CONST_VALUE_HOME_FURNITURE_TYPE_LIMIT = 255,
	CONST_VALUE_HOME_FURNITURE_ARRANGEMENT_COST_LEVEL = 256,
	CONST_VALUE_HOME_LEGO_HEIGHT = 257,
	CONST_VALUE_HOME_ACCELERATE_PARAM = 258,
	CONST_VALUE_HOME_WEEKEND_DJINN_PARAM = 259,
	CONST_VALUE_ACTIVITY_EFFIGY_ICE = 260,
	CONST_VALUE_ACTIVITY_HOMEWORLD = 261,
	CONST_VALUE_HOMEWORLD_TUTRIAL_QUEST = 262,
	CONST_VALUE_CHANNELLER_SLAB_SINGLE_BUFF_ENERGY_LIMIT = 263,
	CONST_VALUE_CHANNELLER_SLAB_MP_BUFF_ENERGY_LIMIT = 264,
	CONST_VALUE_HOME_RESOURCE_PRODUCE_INTERVAL = 265,
	CONST_VALUE_WEEKLY_BOSS_RESIN_DISCOUNT_PARAM = 266,
	CONST_VALUE_BUSH_DROP_CACHA_NUM = 267,
	CONST_VALUE_GENERAL_MATCH = 268,
	CONST_VALUE_HOME_DJINN_PARAM = 269,
	CONST_VALUE_FURNITURE_ITEM_LIMIT = 270,
	CONST_VALUE_SUMMER_TIME_SCENE_ID = 271,
	CONST_VALUE_CAN_NOT_DESTROY_MATERIAL_TYPE_LIST = 272,
	CONST_VALUE_DANGERZONE_GET_LOST_COUNTDOWN = 273,
	CONST_VALUE_SKIFF_SPRINT_COST_STAMINA = 274,
	CONST_VALUE_SKIFF_DASH_COST_STAMINA = 275,
	CONST_VALUE_SIGNAL_ACTIVE_DISTANCE = 276,
	CONST_VALUE_DEFAULT_COSTUME_ICON = 277,
	CONST_VALUE_HERO_COURSE_TRANSFER_CONFIG = 278,
	CONST_VALUE_VEHICLE_CONFIG = 279,
	CONST_VALUE_HOME_GREET_LEAVE_DELAY = 280,
	CONST_VALUE_CHESS_PARAMS = 281,
	CONST_VALUE_GENSHIN_RELEASE_TIME = 282,
	CONST_VALUE_INIT_HOME_TIME = 283,
	CONST_VALUE_HOME_CD_LIMIT = 300,
	CONST_VALUE_HOME_FURNITURE_NUM_LIMIT = 301,
	CONST_VALUE_HOME_RESOURCE_BASE_VALUE = 302,
	CONST_VALUE_HOME_PRIOR_CHECK_TIME_RANGE = 303,
	CONST_VALUE_HOME_PLANT_BOX = 304,
	CONST_VALUE_HOME_WAIT_ENTER_EDIT_FINISH_RSP = 305,
	CONST_VALUE_HOME_FURNITURE_ARRANGEMENT_COST_LEVEL_HALL = 350,
	CONST_VALUE_HOME_FURNITURE_ARRANGEMENT_COST_LEVEL_ROOM = 351,
	CONST_VALUE_HOME_COMFORT_MODIFER = 352,
	CONST_VALUE_HOME_SUITE_FURNITURE_ID = 353,
	CONST_VALUE_HOME_FURNITURE_GROUP_NUM_LIMIT = 354,
	CONST_VALUE_HOME_FURNITURE_GROUP_RECORD_NUM_LIMIT = 355,
	CONST_VALUE_HOME_FURNITURE_CUSTOM_SUITE_PARAM = 356,
	CONST_VALUE_BATTLEPASS_PURCHASE_ABOUT_TO_CLOSE_THRESHOLD = 400,
	CONST_VALUE_BATTLEPASS_PURCHASE_CLOSE_AHEAD_MINUTES = 401,
	CONST_VALUE_ACTIVITY_DAOQI_ADVERTISEMENT = 410,
	CONST_VALUE_MAP_MARK_PARAM = 411,
	CONST_VALUE_GATHER_SAVETYPE_TO_GATHERID = 412,
	CONST_VALUE_HOME_NPC_EVENT_TRANSFER_TIME = 413,
	CONST_VALUE_ACTIVITY_EFFIGY_FIRE = 414,
	CONST_VALUE_ACTIVITY_PERPETUAL = 415,
	CONST_VALUE_MECHANICUS_2_ATTACK = 416,
	CONST_VALUE_MECHANICUS_2_MASTERY = 417,
	CONST_VALUE_MECHANICUS_2_ATTACK_SPEED = 418,
	CONST_VALUE_MECHANICUS_2_ALERT_RANGE = 419,
	CONST_VALUE_CONDENSE_RESINRE_PLACE_RESIN_COUNT = 420,
	CONST_VALUE_BLOSSOM_BAG_REWARD_RADIUS = 422,
	CONST_VALUE_CHESS_CARD_CONFIG = 425,
	CONST_VALUE_PSN_SOCIAL_CONFIG = 426,
	CONST_VALUE_SUMO_ACTIVITY_CONFIG = 427,
	CONST_VALUE_FISHING = 428,
	CONST_VALUE_ELEMENT_MASTERY_PARAM_OVERDOSE = 423,
	CONST_VALUE_GADGET_INTERACT_CHECK_DISTANCE = 424,
	CONST_VALUE_DEFAULT_WEATHER_AREA_ID = 429,
	CONST_VALUE_EMOJI_COLLECT_NUM_LIMIT = 431,
	CONST_VALUE_ACTIVITY_EXPEDITION_2_PARAMS = 440,
	CONST_VALUE_QIANDAOGUA_PARAMS = 441,
	CONST_VALUE_CUSTOM_GADGET_PARTS_MAX_NUM = 442,
	CONST_VALUE_DIG_ACTIVITY_HINT_RAND_DEGREE = 443,
	CONST_VALUE_ROGUELIKE_ACTIVITY_PARAMS = 444,
	CONST_VALUE_MOONFIN_BANNER = 445,
	CONST_VALUE_MINORS_GACHA_PARAM = 446,
	CONST_VALUE_FIREWORKS_LAUNCH_PARAM = 447,
	CONST_VALUE_MICHIAE_MATSURI_ACTIVITY_REGIONAL_PLAY_PARAMS = 448,
	CONST_VALUE_MICHIAE_MATSURI_ACTIVITY_DARK_PRESURE_MAX_PARAMS = 449,
	CONST_VALUE_CUSTOM_DUNGEON_RECOMMEND_1 = 450,
	CONST_VALUE_CUSTOM_DUNGEON_RECOMMEND_2 = 451,
	CONST_VALUE_CUSTOM_DUNGEON_RECOMMEND_FILT = 452,
	CONST_VALUE_CUSTOM_DUNGEON = 453,
	CONST_VALUE_COLLECTIBLE_MAIL_PARAM = 460,
	CONST_VALUE_PLAYER_NPC = 461,
	CONST_VALUE_SHARECD_SERVER_BUFFER_TIME = 462,
	CONST_VALUE_CUSTOMLEVEL_CUSTOMSUITE_BLOCK_MAX_NUM = 463,
	CONST_VALUE_CODEX_GUIDE_PAPAM = 464,
	CONST_VALUE_BAN_NEW_LANGUAGE_SHOW = 465,
	CONST_VALUE_PACKET_LOSS_WARNING_THRESHOLD = 470,
	CONST_VALUE_PACKET_LOSS_WARNING_INTERVAL = 471,
	CONST_VALUE_ACHIEVEMENT_SEARCH_PATTERN_LIMIT = 480,
	CONST_VALUE_SEND_QUESTIONNAIRE_MAIL_LOGOUT_TIME = 481,
	CONST_VALUE_SEND_QUESTIONNAIRE_MAIL_CD_TIME = 482,
	CONST_VALUE_NIGHT_CROW_CONFIG = 483,
	CONST_VALUE_HANDBOOK_QUEST_GUIDE_MAX_NUM = 484,
	CONST_VALUE_SUMMER_TIME_PORTAL_LOADING = 485,
	CONST_VALUE_ACHIEVEMENT_SEARCH_LIMIT = 600,
}