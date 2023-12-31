﻿using UserCenter.Model;

namespace UserCenter.Core.Abstractions
{
    public interface IUserProvider
    {
        Task AddAsync(string userName, string password);

        Task RemoveAsync(string userId);

        Task ChangePasswordAsync(UserPassword user);

        Task<bool> ExistAsync(string userName);

        Task<UserInfo[]> GetUsersAsync(UserQueryParams queryParams);

        Task<UserBaseInfo[]> GetUsersAsync(string[] userIds);

        Task<long> GetUserCountAsync(UserQueryParams queryParams);

        Task<UserBaseInfo?> LoginAsync(string userName, string password);

        Task<UserBaseInfo?> GetByIdAsync(string userId);
    }
}
