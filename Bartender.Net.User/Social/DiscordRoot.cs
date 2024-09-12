﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Social;

//TODO can just move this into it's own folder
public class DiscordRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("discord")]
    public required DiscordRecord Discord { get; set; }
}
