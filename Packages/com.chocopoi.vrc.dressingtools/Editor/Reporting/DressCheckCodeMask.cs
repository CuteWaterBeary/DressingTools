﻿namespace Chocopoi.DressingTools.Reporting
{
    public class DressCheckCodeMask
    {
        public enum Info
        {
            //Info
            NON_MATCHING_CLOTHES_BONE_KEPT_UNTOUCHED = 0x0001,
            DYNAMIC_BONE_ALL_IGNORED = 0x02,
            EXISTING_PREFIX_DETECTED_NOT_REMOVED = 0x0004,
            EXISTING_PREFIX_DETECTED_AND_REMOVED = 0x0008,
            EXISTING_SUFFIX_DETECTED_NOT_REMOVED = 0x0010,
            EXISTING_SUFFIX_DETECTED_AND_REMOVED = 0x0020,
            AVATAR_ARMATURE_OBJECT_GUESSED = 0x0040,
            CLOTHES_ARMATURE_OBJECT_GUESSED = 0x0080,
            MULTIPLE_BONES_IN_AVATAR_ARMATURE_FIRST_LEVEL_WARNING_REMOVED = 0x0100 //only one enabled bone detected, others are disabled (e.g. Maya has a C object that is disabled)
        }

        public enum Warn
        {
            //Warning
            MULTIPLE_BONES_IN_AVATAR_ARMATURE_FIRST_LEVEL = 0x01,
            MULTIPLE_BONES_IN_CLOTHES_ARMATURE_FIRST_LEVEL = 0x02,
            BONES_NOT_MATCHING_IN_ARMATURE_FIRST_LEVEL = 0x04,
        }

        public enum Error
        {
            //Errors
            NO_ARMATURE_IN_AVATAR = 0x0001,
            NO_ARMATURE_IN_CLOTHES = 0x0002,
            NULL_ACTIVE_AVATAR_OR_CLOTHES = 0x0004,
            NO_BONES_IN_AVATAR_ARMATURE_FIRST_LEVEL = 0x0008,
            NO_BONES_IN_CLOTHES_ARMATURE_FIRST_LEVEL = 0x0010,
            CLOTHES_IS_A_PREFAB = 0x0020,
            EXISTING_CLOTHES_DETECTED = 0x0040,
            MISSING_SCRIPTS_DETECTED_IN_AVATAR = 0x0080,
            MISSING_SCRIPTS_DETECTED_IN_CLOTHES = 0x0100,
            CLOTHES_INSIDE_AVATAR = 0x0200,
            AVATAR_INSIDE_CLOTHES = 0x0400,
        }
    }

}
