﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XNode;

namespace TheBitCave.MMToolsExtensions.AI.Graph
{
    /// <summary>
    /// A Graph to create AI Brains for the Corgi <see cref="MoreMountains.Tools.AIBrain"/>.
    /// </summary>
    [Serializable, CreateAssetMenu(fileName = "New Brain SubGraph", menuName = "The Bit Cave/AI Brain SubGraph")]
    public class AIBrainSubgraph : NodeGraph, IBrainGraph
    {
        /// <summary>
        /// Which state should be initialized as the starting one.
        /// </summary>
        public AIBrainStateNode StartingNode
        {
            get;
            set;
        }

        public IEnumerable<AIStateInNode> GetStatesIn()
        {
            return nodes.OfType<AIStateInNode>()
                .Select(node => (node as AIStateInNode))
                .ToList();
        }
    }
}