﻿using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttackStub {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("code")]
    public required string Code { get; set; }

    [JsonProperty ("timestamp_started")]
    public long TimestampStarted { get; set; }

    [JsonProperty ("timestamp_ended")]
    public long TimestampEnded { get; set; }

    [JsonProperty ("attacker_id")]
    public required int AttackerId { get; set; }

    [JsonProperty ("attacker_faction")]
    public required int AttackerFaction { get; set; }

    [JsonProperty ("defender_id")]
    public required int DefenderId { get; set; }

    [JsonProperty ("defender_faction")]
    public required int DefenderFaction { get; set; }

    [JsonProperty ("result")]
    public required string Result { get; set; }

    [JsonProperty ("stealthed")]
    public required int Stealthed { get; set; }

    [JsonProperty ("respect")]
    public required int Respect { get; set; }
}
