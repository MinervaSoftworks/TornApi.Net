﻿namespace Bartender.Net.Framework.Common.News;

public class NewsEntry : IBartenderEntity {
    public required string News { get; set; }

    public required long Timestamp { get; set; }

    public int ID { get; set; }
}