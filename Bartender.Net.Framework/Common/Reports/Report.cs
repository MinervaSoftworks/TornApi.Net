﻿using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Extensions.User;
using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class Report {
    [JsonProperty ("id")]
    public int ID { get; set; }

    [JsonProperty ("report")]
    public required ReportData Data { get; set; }

    [JsonProperty ("target")]
    public required int Target { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonIgnore]
    public ReportType ReportType {
        get => Type.ToReportType ();
        set => Type = value.ToReportTypeString ();
    }

    [JsonProperty ("user_id")]
    public required int UserID { get; set; }
}