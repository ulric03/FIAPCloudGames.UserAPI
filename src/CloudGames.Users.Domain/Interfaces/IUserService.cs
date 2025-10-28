﻿using CloudGames.Users.Domain.Requests;
using CloudGames.Users.Domain.Responses;

namespace CloudGames.Users.Domain.Interfaces;

public interface IUserService
{
    Task<UserResponse> Create(CreateUserRequest request);

    Task Update(UpdateUserRequest request);

    Task Delete(int id);

    Task<UserResponse?> GetById(int id);

    Task<UserResponse?> GetByEmail(string email);

    Task<IEnumerable<UserResponse>> GetAll();

    Task Active(int id);

    Task Inactive(int id);

    Task<TokenResponse> Login(LoginRequest request);
}
