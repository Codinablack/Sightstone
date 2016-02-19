﻿using System;
using RtmpSharp.IO;

namespace Sightstone.RiotConnect.Riot.com.riotgames.platform.gameinvite.contract
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.Invitee")]
    public class Invitee : IRiotRtmpObject
    {
        [SerializedName("inviteeStateAsString")]
        public string InviteeState { get; set; }

        [SerializedName("summonerName")]
        public string SummonerName { get; set; }

        [SerializedName("inviteeState")]
        public string inviteeState { get; set; }

        [SerializedName("summonerId")]
        public double SummonerId { get; set; }
    }
}