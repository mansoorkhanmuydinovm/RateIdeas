﻿namespace RateIdeas.Application.Comments.DTOs;

public class ComentResultForPropDto
{
    public long Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public UserResultForPropDto User { get; set; } = default!;
    public long IdeaId { get; set; } = default!;
}