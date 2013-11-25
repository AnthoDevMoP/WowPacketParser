using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_1_17538
{
    public static class Opcodes_5_4_1
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_NAME_QUERY, 0x11E9}, //17538
            {Opcode.CMSG_REALM_QUERY, 0x09E1}, //17538
            {Opcode.CMSG_AUTH_SESSION, 0x14DA}, //17538
            {Opcode.CMSG_CHAR_CREATE, 0x08CD}, //17538
            {Opcode.CMSG_CHAR_DELETE, 0x09C0}, //17538
            {Opcode.CMSG_CHAR_ENUM, 0x0848}, //17538
            {Opcode.CMSG_CREATURE_QUERY, 0x1647}, //17538
            {Opcode.CMSG_DB_QUERY_BULK, 0x01E4}, //17538
            {Opcode.CMSG_DISMISS_CONTROLLED_VEHICLE, 0x1261}, //17538
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x1677}, //17538
            {Opcode.CMSG_LEARN_TALENT, 0x1776}, //17538
            {Opcode.CMSG_LOAD_SCREEN, 0x1148}, //17538
            {Opcode.CMSG_LOGOUT_REQUEST, 0x03EC}, //17538
            {Opcode.CMSG_LOG_DISCONNECT, 0x14FA}, //17538
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x14FC}, //17538
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x14D8}, //17538
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x045C}, //17538
            {Opcode.CMSG_MOVE_CHNG_TRANSPORT, 0x1361}, //17538
            {Opcode.CMSG_MOVE_FALL_RESET, 0x12C1}, //17538
            {Opcode.CMSG_MOVE_SET_FLY, 0x1769}, //17538
            {Opcode.CMSG_MOVE_SET_CAN_FLY, 0x063E}, //17538
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x17CF}, //17538
            {Opcode.CMSG_OBJECT_UPDATE_FAILED, 0x1A44}, //17538
            {Opcode.CMSG_PING, 0x11E6}, //17538
            {Opcode.CMSG_PLAYER_LOGIN, 0x01E1}, //17538
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x184C}, //17538
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x144C}, //17538
            {Opcode.CMSG_REALM_SPLIT, 0x0449}, //17538
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x014C}, //17538
            {Opcode.CMSG_SET_ACTIVE_MOVER, 0x1A4D}, //17538
            {Opcode.CMSG_SET_SELECTION, 0x07CD}, //17538
            {Opcode.CMSG_SET_SPECIALIZATION, 0x17DF}, //17538
            {Opcode.CMSG_TIME_SYNC_RESP, 0x11E6}, //17538
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x13CD}, //17538
            {Opcode.CMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x04EC}, //17538
            {Opcode.MSG_MOVE_FALL_LAND, 0x17E9}, //17538
            {Opcode.MSG_MOVE_HEARTBEAT, 0x0AC8}, //17538
            {Opcode.MSG_MOVE_JUMP, 0x07C9}, //17538
            {Opcode.MSG_MOVE_SET_FACING, 0x1368}, //17538
            {Opcode.MSG_MOVE_SET_PITCH, 0x0261}, //17538
            {Opcode.MSG_MOVE_SET_RUN_MODE, 0x0748}, //17538
            {Opcode.MSG_MOVE_SET_WALK_MODE, 0x0BE1}, //17538
            {Opcode.MSG_MOVE_START_ASCEND, 0x16C1}, //17538
            {Opcode.MSG_MOVE_START_BACKWARD, 0x12C0}, //17538
            {Opcode.MSG_MOVE_START_DESCEND, 0x0641}, //17538
            {Opcode.MSG_MOVE_START_FORWARD, 0x13C9}, //17538
            {Opcode.MSG_MOVE_START_PITCH_DOWN, 0x16E8}, //17538
            {Opcode.MSG_MOVE_START_PITCH_UP, 0x0FE1}, //17538
            {Opcode.MSG_MOVE_START_STRAFE_LEFT, 0x0EC8}, //17538
            {Opcode.MSG_MOVE_START_STRAFE_RIGHT, 0x0269}, //17538
            {Opcode.MSG_MOVE_START_SWIM, 0x0FC8}, //17538
            {Opcode.MSG_MOVE_START_TURN_LEFT, 0x0760}, //17538
            {Opcode.MSG_MOVE_START_TURN_RIGHT, 0x17C9}, //17538
            {Opcode.MSG_MOVE_STOP, 0x0649}, //17538
            {Opcode.MSG_MOVE_STOP_ASCEND, 0x1268}, //17538
            {Opcode.MSG_MOVE_STOP_PITCH, 0x1A48}, //17538
            {Opcode.MSG_MOVE_STOP_STRAFE, 0x12C9}, //17538
            {Opcode.MSG_MOVE_STOP_SWIM, 0x0FC9}, //17538
            {Opcode.MSG_MOVE_STOP_TURN, 0x1749}, //17538
            {Opcode.MSG_MOVE_TELEPORT, 0x0A2E}, //17538
            {Opcode.MSG_MOVE_TOGGLE_COLLISION_CHEAT, 0x0BC8}, //17538
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x1486}, //17538
            {Opcode.SMSG_ACTION_BUTTONS, 0x0406}, //17538
            {Opcode.SMSG_ADDON_INFO, 0x1136}, //17538
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0C5D}, //17538
            {Opcode.SMSG_AUTH_RESPONSE, 0x0D05}, //17538
            {Opcode.SMSG_CHAR_CREATE, 0x1007}, //17538
            {Opcode.SMSG_CHAR_DELETE, 0x0017}, //17538
            {Opcode.SMSG_CHAR_ENUM, 0x040E}, //17538
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x1037}, //17538
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x011C}, //17538
            {Opcode.SMSG_DB_REPLY, 0x1406}, //17538
            {Opcode.SMSG_DESTROY_OBJECT, 0x04B4}, //17538
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x0916}, //17538
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x03FC}, //17538
            {Opcode.SMSG_INITIAL_SPELLS, 0x1164}, //17538
            {Opcode.SMSG_LEARNED_SPELL, 0x118E}, //17538
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x0D17}, //17538
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0896},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0D95}, //17538
            {Opcode.SMSG_MESSAGECHAT, 0x14AC}, //17538
            {Opcode.SMSG_MOTD, 0x04AC}, //17538
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x0209}, //17538
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x02B2}, //17538
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x06A5}, //17538
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x0A0D}, //17538
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x0716}, //17538
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x031B}, //17538
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x1407}, //17538
            {Opcode.SMSG_NEW_WORLD, 0x010F}, //17538
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x101F}, //17538
            {Opcode.SMSG_PLAYED_TIME, 0x05AC}, //17538
            {Opcode.SMSG_PLAYER_MOVE, 0x0337}, //17538
            {Opcode.SMSG_PONG, 0x005D}, //17538
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x081E}, //17538
            {Opcode.SMSG_REALM_SPLIT, 0x0884}, //17538
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x052D}, //17538
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x049E}, //17538
            {Opcode.SMSG_TALENTS_INFO, 0x0494}, //17538
            {Opcode.SMSG_TRANSFER_PENDING, 0x0917}, //17538
            {Opcode.SMSG_TRIGGER_CINEMATIC, 0x0198}, //17538
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0D1B}, //17538
            {Opcode.SMSG_UPDATE_OBJECT, 0x0C22}, //17538
        };
    }
}
