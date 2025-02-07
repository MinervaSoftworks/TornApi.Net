﻿using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyProfileEmployee : BartenderEntity {
    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public required int DaysInCompany { get; set; }

    [JsonProperty ("last_action")]
    public virtual required LastAction LastAction { get; set; }
}
