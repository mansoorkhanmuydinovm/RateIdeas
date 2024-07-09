﻿namespace RateIdeas.Domain.Common;

public class Auditable
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}
