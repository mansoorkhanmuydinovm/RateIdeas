﻿global using AutoMapper;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.Extensions.DependencyInjection;
global using RateIdeas.Application.Assets.Commands;
global using RateIdeas.Application.Assets.DTOs;
global using RateIdeas.Application.Categories.Commands;
global using RateIdeas.Application.Categories.DTOs;
global using RateIdeas.Application.Categories.Queries;
global using RateIdeas.Application.Comments.Commands;
global using RateIdeas.Application.Comments.DTOs;
global using RateIdeas.Application.Comments.Queries;
global using RateIdeas.Application.CommentVotes.Commands;
global using RateIdeas.Application.CommentVotes.DTOs;
global using RateIdeas.Application.CommentVotes.Queries;
global using RateIdeas.Application.Commons.Constants;
global using RateIdeas.Application.Commons.Exceptions;
global using RateIdeas.Application.Commons.Helpers;
global using RateIdeas.Application.Commons.Interfaces;
global using RateIdeas.Application.Commons.Mappers;
global using RateIdeas.Application.Ideas.Commands;
global using RateIdeas.Application.Ideas.DTOs;
global using RateIdeas.Application.Ideas.Queries;
global using RateIdeas.Application.IdeaVotes.Commands;
global using RateIdeas.Application.IdeaVotes.DTOs;
global using RateIdeas.Application.IdeaVotes.Queries;
global using RateIdeas.Application.SavedIdeas.Commands;
global using RateIdeas.Application.SavedIdeas.DTOs;
global using RateIdeas.Application.SavedIdeas.Queries;
global using RateIdeas.Application.Users.Commands;
global using RateIdeas.Application.Users.DTOs;
global using RateIdeas.Application.Users.Queries;
global using RateIdeas.Domain.Entities;
global using RateIdeas.Domain.Entities.Comments;
global using RateIdeas.Domain.Entities.Ideas;
global using System.Text.Json.Serialization;
global using RateIdeas.Application.Users.Commands.CreateUser;
global using RateIdeas.Application.Users.Commands.DeleteUser;
global using RateIdeas.Application.Users.Commands.UpdateUser;