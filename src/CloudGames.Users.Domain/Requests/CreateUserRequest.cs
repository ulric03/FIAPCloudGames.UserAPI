﻿using CloudGames.Users.Domain.Enums;

namespace CloudGames.Users.Domain.Requests;

public sealed class CreateUserRequest
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Login { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public UserRole UserType { get; set; }

    public bool IsActive { get; set; }
}
