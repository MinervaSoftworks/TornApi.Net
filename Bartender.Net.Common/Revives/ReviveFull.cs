﻿using Bartender.Net.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Common.Revives;

public class ReviveFull {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("chance")]
    public required double Chance { get; set; }

    [JsonProperty ("result")]
    public required string Result { get; set; }

    [JsonProperty ("reviver_faction")]
    public required int ReviverFaction { get; set; }

    [JsonProperty ("reviver_id")]
    public required int ReviverId { get; set; }

    [JsonProperty ("target_early_discharge")]
    public required int TargetEarlyDischarge { get; set; }

    [JsonProperty ("target_faction")]
    public required int TargetFaction { get; set; }

    [JsonProperty ("target_hospital_reason")]
    public required string TargetHospitalReason { get; set; }

    [JsonProperty ("target_id")]
    public required int TargetId { get; set; }

    [JsonProperty ("target_last_action")]
    public required LastAction TargetLastAction { get; set; }

    [JsonProperty ("timestamp")]
    public required int TimeStamp { get; set; }
}
