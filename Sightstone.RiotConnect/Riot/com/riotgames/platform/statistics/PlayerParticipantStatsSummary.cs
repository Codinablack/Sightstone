﻿using System;
using System.Collections.Generic;
using RtmpSharp.IO;
using Sightstone.RiotConnect.Riot.com.riotgames.team;

namespace Sightstone.RiotConnect.Riot.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerParticipantStatsSummary")]
    public class PlayerParticipantStatsSummary : IRiotRtmpObject
    {
        [SerializedName("skinName")]
        public string SkinName { get; set; }

        [SerializedName("gameId")]
        public double GameId { get; set; }

        [SerializedName("profileIconId")]
        public int ProfileIconId { get; set; }

        [SerializedName("elo")]
        public int Elo { get; set; }

        [SerializedName("leaver")]
        public bool Leaver { get; set; }

        [SerializedName("leaves")]
        public double Leaves { get; set; }

        [SerializedName("teamId")]
        public double TeamId { get; set; }

        [SerializedName("eloChange")]
        public int EloChange { get; set; }

        [SerializedName("statistics")]
        public List<RawStatDTO> Statistics { get; set; }

        [SerializedName("level")]
        public double Level { get; set; }

        [SerializedName("botPlayer")]
        public bool BotPlayer { get; set; }

        [SerializedName("isMe")]
        public bool IsMe { get; set; }

        [SerializedName("inChat")]
        public bool InChat { get; set; }

        [SerializedName("userId")]
        public double UserId { get; set; }

        [SerializedName("spell2Id")]
        public double Spell2Id { get; set; }

        [SerializedName("losses")]
        public double Losses { get; set; }

        [SerializedName("summonerName")]
        public string SummonerName { get; set; }

        [SerializedName("wins")]
        public double Wins { get; set; }

        [SerializedName("spell1Id")]
        public double Spell1Id { get; set; }

        [SerializedName("teamInfo")]
        public TeamInfo TeamInfo { get; set; }

        [SerializedName("reportEnabled")]
        public bool ReportEnabled { get; set; }

        [SerializedName("kudosEnabled")]
        public bool KudosEnabled { get; set; }
    }
}