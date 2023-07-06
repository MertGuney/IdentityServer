﻿global using IdentityModel;
global using IdentityServer.Application;
global using IdentityServer.Application.Common.Extensions;
global using IdentityServer.Application.Features.Commands.Auth.Codes.SendChangeEmailCode;
global using IdentityServer.Application.Features.Commands.Auth.Codes.SendChangePasswordCode;
global using IdentityServer.Application.Features.Commands.Auth.Codes.SendForgotPasswordCode;
global using IdentityServer.Application.Features.Commands.Auth.Codes.SendRegisterCode;
global using IdentityServer.Application.Features.Commands.Auth.Register;
global using IdentityServer.Application.Features.Commands.Auth.ResetPassword;
global using IdentityServer.Application.Features.Commands.Auth.TFAs.Activate;
global using IdentityServer.Application.Features.Commands.Auth.TFAs.Deactivate;
global using IdentityServer.Application.Features.Commands.Auth.TFAs.Enable;
global using IdentityServer.Application.Features.Commands.Users.ChangeEmail;
global using IdentityServer.Application.Features.Commands.Users.ChangePassword;
global using IdentityServer.Application.Features.Queries.Users.GetCurrentUser;
global using IdentityServer.Infrastructure;
global using IdentityServer.Persistence;
global using IdentityServer.Persistence.SeedData;
global using IdentityServer.Shared.Models;
global using MediatR;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Mvc;
global using static Duende.IdentityServer.IdentityServerConstants;
