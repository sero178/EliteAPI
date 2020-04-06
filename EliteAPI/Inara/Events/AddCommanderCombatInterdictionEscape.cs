﻿using Newtonsoft.Json;
namespace EliteAPI.Inara.Events
{
    public class AddCommanderCombatInterdictionEscape : IInaraEventData
    {
        public AddCommanderCombatInterdictionEscape(string starsystemName, string opponentName, bool isPlayer)
        {
            StarsystemName = starsystemName;
            OpponentName = opponentName;
            IsPlayer = isPlayer;
        }
        [JsonProperty("starsystemName")]
        public string StarsystemName { get; set; }
        [JsonProperty("opponentName")]
        public string OpponentName { get; set; }
        [JsonProperty("isPlayer")]
        public bool IsPlayer { get; set; }
    }
}
