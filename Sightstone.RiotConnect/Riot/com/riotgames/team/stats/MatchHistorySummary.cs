﻿using System;
using RtmpSharp.IO;

namespace Sightstone.RiotConnect.Riot.com.riotgames.team.stats
{
    [Serializable]
    [SerializedName("com.riotgames.team.stats.MatchHistorySummary")]
    public class MatchHistorySummary : IRiotRtmpObject
    {
        [SerializedName("gameMode")]
        public string GameMode { get; set; }

        [SerializedName("mapId")]
        public int MapId { get; set; }

        [SerializedName("assists")]
        public int Assists { get; set; }

        [SerializedName("opposingTeamName")]
        public string OpposingTeamName { get; set; }

        [SerializedName("invalid")]
        public bool Invalid { get; set; }

        [SerializedName("deaths")]
        public int Deaths { get; set; }

        [SerializedName("gameId")]
        public double GameId { get; set; }

        [SerializedName("kills")]
        public int Kills { get; set; }

        [SerializedName("win")]
        public bool Win { get; set; }

        [SerializedName("date")]
        public double Date { get; set; }

        [SerializedName("opposingTeamKills")]
        public int OpposingTeamKills { get; set; }
    }
}