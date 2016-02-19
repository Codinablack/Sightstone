﻿using System;
using RtmpSharp.IO;
using Sightstone.RiotConnect.Riot.com.riotgames.platform.game.map;

namespace Sightstone.RiotConnect.Riot.com.riotgames.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.PracticeGameConfig")]
    public class PracticeGameConfig : IRiotRtmpObject
    {
        [SerializedName("passbackUrl")]
        public object PassbackUrl { get; set; }

        [SerializedName("gameName")]
        public string GameName { get; set; }

        [SerializedName("gameTypeConfig")]
        public int GameTypeConfig { get; set; }

        [SerializedName("passbackDataPacket")]
        public object PassbackDataPacket { get; set; }

        [SerializedName("gamePassword")]
        public string GamePassword { get; set; }

        [SerializedName("gameMap")]
        public GameMap GameMap { get; set; }

        [SerializedName("gameMode")]
        public string GameMode { get; set; }

        [SerializedName("allowSpectators")]
        public string AllowSpectators { get; set; }

        [SerializedName("maxNumPlayers")]
        public int MaxNumPlayers { get; set; }

        [SerializedName("region")]
        public string Region { get; set; }
    }
}