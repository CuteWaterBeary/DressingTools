﻿using System;

namespace Chocopoi.DressingTools.Cabinet
{
    [Serializable]
    public class DTCabinetWearable : DTWearableConfig
    {
        public DTGameObjectReference[] objectReferences;
        public string serializedJson;
    }
}
