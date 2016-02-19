﻿using System;
using RtmpSharp.IO;

namespace Sightstone.RiotConnect.Riot.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.AggregatedStat")]
    public class AggregatedStat : IRiotRtmpObject
    {
        [SerializedName("statType")]
        public string StatType { get; set; }

        [SerializedName("count")]
        public double Count { get; set; }

        [SerializedName("value")]
        public double Value { get; set; }

        [SerializedName("championId")]
        public double ChampionId { get; set; }
    }
}