﻿using RateIdeas.Application.IdeaVotes.Commands;
using RateIdeas.Application.IdeaVotes.DTOs;
using RateIdeas.Application.IdeaVotes.Queries;
using RateIdeas.WebApi.Controllers.Commons;

namespace RateIdeas.WebApi.Controllers.IdeaVotes;

public class IdeaVotesController(IMediator mediator) : BaseController
{
    [HttpPost("toggle-idea-vote")]
    [ProducesResponseType(typeof(IdeaVoteResultDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> Toggle(ToggleIdeaVoteCommand command,
        CancellationToken cancellationToken)
        => Ok(new Response
        {
            Data = await mediator.Send(command, cancellationToken)
        });

    [HttpGet("get/{userId:long}")]
    [ProducesResponseType(typeof(IdeaVoteResultDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(long userId, CancellationToken cancellationToken)
        => Ok(new Response
        {
            Data = await mediator.Send(new GetIdeaVoteQuery(userId), cancellationToken)
        });

    [HttpGet("get-all")]
    [ProducesResponseType(typeof(IEnumerable<IdeaVoteResultDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetForApplication([FromQuery] GetAllIdeaVotesQuery query,
        CancellationToken cancellationToken)
        => Ok(new Response
        {
            Data = await mediator.Send(query, cancellationToken)
        });
}
