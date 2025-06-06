﻿using Ray.BiliBiliTool.Agent.BiliBiliAgent.Services;

namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos.Video;

public class SearchVideosByUpIdDto : IWrid
{
    /// <summary>
    /// upId
    /// </summary>
    public long mid { get; set; }

    /// <summary>
    /// pageSize
    /// </summary>
    public int ps { get; set; } = 30;

    /// <summary>
    /// pageNumber
    /// </summary>
    public int pn { get; set; } = 1;

    public int tid { get; set; } = 0;

    public string keyword { get; set; } = "";

    public string order { get; set; } = "pubdate";

    public string platform { get; set; } = "web";

    public int web_location { get; set; } = 1550101;

    public string order_avoided { get; set; } = "true";

    public string? w_rid { get; set; }

    public long wts { get; set; }
}
