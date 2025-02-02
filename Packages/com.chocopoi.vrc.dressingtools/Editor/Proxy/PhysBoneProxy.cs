﻿using System.Collections.Generic;
using UnityEngine;

namespace Chocopoi.DressingTools.Proxy
{
    public class PhysBoneProxy : IDynamicsProxy
    {
        private static System.Type PhysBoneType = DressingUtils.FindType("VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBone");

        public PhysBoneProxy(Component component)
        {
            Component = component;
            if (PhysBoneType == null)
            {
                throw new System.Exception("No VRCPhysBone component is found in this project. It is required to process PhysBone-based clothes.");
            }
        }

        public Component Component { get; }

        public Transform Transform
        {
            get { return Component.transform; }
        }

        public GameObject GameObject
        {
            get { return Component.gameObject; }
        }

        public Transform RootTransform
        {
            get { return (Transform)PhysBoneType.GetField("rootTransform").GetValue(Component); }
            set { PhysBoneType.GetField("rootTransform").SetValue(Component, value); }
        }

        public List<Transform> IgnoreTransforms
        {
            get { return (List<Transform>)PhysBoneType.GetField("ignoreTransforms").GetValue(Component); }
            set { PhysBoneType.GetField("ignoreTransforms").SetValue(Component, value); }
        }
    }
}
