﻿using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Perks {
    [JsonProperty("faction_perks")]
    public List<string> FactionPerks { get; set; }

    [JsonProperty("job_perks")]
    public List<string> JobPerks { get; set; }

    [JsonProperty("property_perks")]
    public List<string> PropertyPerks { get; set; }

    [JsonProperty("education_perks")]
    public List<string> EducationPerks { get; set; }

    [JsonProperty("enhancer_perks")]
    public List<string> EnhancerPerks { get; set; }

    [JsonProperty("book_perks")]
    public List<object> BookPerks { get; set; }

    [JsonProperty("stock_perks")]
    public List<string> StockPerks { get; set; }

    [JsonProperty("merit_perks")]
    public List<string> MeritPerks { get; set; }
}