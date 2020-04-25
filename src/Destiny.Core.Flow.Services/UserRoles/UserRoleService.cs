﻿using Destiny.Core.Flow.Dependency;
using Destiny.Core.Flow.Extensions;
using Destiny.Core.Flow.IServices.UserRoles;
using Destiny.Core.Flow.Model.Entities.Identity;
using Destiny.Core.Flow.Model.RepositoryBase;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny.Core.Flow.Services.UserRoles
{
    /// <summary>
    /// 用户角色
    /// </summary>
    [Dependency(ServiceLifetime.Scoped)]
    public class UserRoleService: IUserRoleService
    {
        private readonly IEFCoreRepository<UserRole, Guid> _repositoryUserRole = null;

        private readonly RoleManager<Role> _roleManager = null;

        public UserRoleService(IEFCoreRepository<UserRole, Guid> repositoryUserRole, RoleManager<Role> roleManager)
        {
            _repositoryUserRole = repositoryUserRole;
            _roleManager = roleManager;
        }

        public IQueryable<UserRole> UserRoles => _repositoryUserRole.Entities;

        public IQueryable<UserRole> TrackUserRoles => _repositoryUserRole.TrackEntities;

        private IQueryable<Role> GetRoleJoinUserRoleByUserId(Guid userId)
        {
            var userRoles = this.UserRoles.Where(ur => ur.UserId == userId);
            var roles = _roleManager.Roles;
            return roles.Join(userRoles, r => r.Id, ur => ur.RoleId, (r, ur) => r);
        }

        /// <summary>
        /// 异步根据用户ID得到角色Id
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>返回角色Id集合</returns>
        public async Task<Guid[]> GetRoleIdsByUserIdAsync(Guid userId)
        {
            userId.NotEmpty(nameof(userId));
            var roleIds = await this.GetRoleJoinUserRoleByUserId(userId).Select(r => r.Id).ToArrayAsync();
            return roleIds;
        }
    }
}
