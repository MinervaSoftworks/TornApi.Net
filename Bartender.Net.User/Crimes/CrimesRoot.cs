﻿using Bartender.Net.User.CrimeRecord;
using Newtonsoft.Json;

namespace Bartender.Net.User.Crimes;

public class CrimesRoot {
    [JsonProperty ("criminalrecord")]
    public required CrimnalRecordCollection Crimes { get; set; }
}