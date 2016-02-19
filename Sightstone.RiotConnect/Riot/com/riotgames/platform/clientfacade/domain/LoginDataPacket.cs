﻿using System;
using System.Collections.Generic;
using RtmpSharp.IO;
using Sightstone.RiotConnect.Riot.com.riotgames.kudos.dto;
using Sightstone.RiotConnect.Riot.com.riotgames.platform.broadcast;
using Sightstone.RiotConnect.Riot.com.riotgames.platform.game;
using Sightstone.RiotConnect.Riot.com.riotgames.platform.statistics;
using Sightstone.RiotConnect.Riot.com.riotgames.platform.summoner;
using Sightstone.RiotConnect.Riot.com.riotgames.platform.systemstate;

namespace Sightstone.RiotConnect.Riot.com.riotgames.platform.clientfacade.domain
{
    [Serializable]
    [SerializedName("com.riotgames.platform.clientfacade.domain.LoginDataPacket")]
    public class LoginDataPacket : IRiotRtmpObject
    {
        [SerializedName("restrictedGamesRemainingForRanked")]
        public int RestrictedGamesRemainingForRanked { get; set; }

        [SerializedName("playerStatSummaries")]
        public PlayerStatSummaries PlayerStatSummaries { get; set; }

        [SerializedName("restrictedChatGamesRemaining")]
        public int RestrictedChatGamesRemaining { get; set; }

        [SerializedName("minutesUntilShutdown")]
        public int MinutesUntilShutdown { get; set; }

        [SerializedName("minor")]
        public bool Minor { get; set; }

        [SerializedName("maxPracticeGameSize")]
        public int MaxPracticeGameSize { get; set; }

        [SerializedName("summonerCatalog")]
        public SummonerCatalog SummonerCatalog { get; set; }

        [SerializedName("ipBalance")]
        public double IpBalance { get; set; }

        [SerializedName("reconnectInfo")]
        public object ReconnectInfo { get; set; }

        [SerializedName("languages")]
        public List<string> Languages { get; set; }

        [SerializedName("simpleMessages")]
        public List<object> SimpleMessages { get; set; }

        [SerializedName("allSummonerData")]
        public AllSummonerData AllSummonerData { get; set; }

        [SerializedName("customMinutesLeftToday")]
        public int CustomMinutesLeftToday { get; set; }

        [SerializedName("platformGameLifecycleDTO")]
        public object PlatformGameLifecycleDTO { get; set; }

        [SerializedName("coOpVsAiMinutesLeftToday")]
        public int CoOpVsAiMinutesLeftToday { get; set; }

        [SerializedName("bingeData")]
        public object BingeData { get; set; }

        [SerializedName("inGhostGame")]
        public bool InGhostGame { get; set; }

        [SerializedName("leaverPenaltyLevel")]
        public int LeaverPenaltyLevel { get; set; }

        [SerializedName("bingePreventionSystemEnabledForClient")]
        public bool BingePreventionSystemEnabledForClient { get; set; }

        [SerializedName("pendingBadges")]
        public int PendingBadges { get; set; }

        [SerializedName("broadcastNotification")]
        public BroadcastNotification BroadcastNotification { get; set; }

        [SerializedName("minutesUntilMidnight")]
        public int MinutesUntilMidnight { get; set; }

        [SerializedName("timeUntilFirstWinOfDay")]
        public double TimeUntilFirstWinOfDay { get; set; }

        [SerializedName("coOpVsAiMsecsUntilReset")]
        public double CoOpVsAiMsecsUntilReset { get; set; }

        [SerializedName("clientSystemStates")]
        public ClientSystemStatesNotification ClientSystemStates { get; set; }

        [SerializedName("bingeMinutesRemaining")]
        public double BingeMinutesRemaining { get; set; }

        [SerializedName("pendingKudosDTO")]
        public PendingKudosDTO PendingKudosDTO { get; set; }

        [SerializedName("leaverBusterPenaltyTime")]
        public int LeaverBusterPenaltyTime { get; set; }

        [SerializedName("platformId")]
        public string PlatformId { get; set; }

        [SerializedName("matchMakingEnabled")]
        public bool MatchMakingEnabled { get; set; }

        [SerializedName("minutesUntilShutdownEnabled")]
        public bool MinutesUntilShutdownEnabled { get; set; }

        [SerializedName("rpBalance")]
        public double RpBalance { get; set; }

        [SerializedName("gameTypeConfigs")]
        public List<GameTypeConfigDTO> GameTypeConfigs { get; set; }

        [SerializedName("bingeIsPlayerInBingePreventionWindow")]
        public bool BingeIsPlayerInBingePreventionWindow { get; set; }

        [SerializedName("minorShutdownEnforced")]
        public bool MinorShutdownEnforced { get; set; }

        [SerializedName("competitiveRegion")]
        public string CompetitiveRegion { get; set; }

        [SerializedName("customMsecsUntilReset")]
        public double CustomMsecsUntilReset { get; set; }
    }
}