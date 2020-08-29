using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor

    {
        public async Task<GroupVM> AddGroup(GroupVM groupVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
    {
        var groupUsers = _Mapper.Map<List<User>>(groupVM.Users);

        var group = _Mapper.Map<GroupVM, Groups>(groupVM);
        GeneralMethod.AddBaseProperties<Groups>(group, accessor, user, true);

        var newGroup = await _GroupRepository.AddGroup(group, groupUsers, accessor, ct);
        return _Mapper.Map<Groups, GroupVM>(newGroup);
    }
        public async Task<bool> AddUsers(long id, List<long> usersId, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            if (usersId.Count != 0)
            {
                List<UserGroup> userGroups = new List<UserGroup>();

                foreach (var userId in usersId)
                {
                    UserGroup userGroup = new UserGroup()
                    {
                        GroupID = id,

                        UserID = userId
                    };

                    userGroups.Add(userGroup);
                }
                foreach (var userGroup in userGroups)
                {
                    GeneralMethod.AddBaseProperties(userGroup, accessor, user, true);
                }
                await _GroupRepository.AddUsersForGroup(userGroups, ct);

            }
            return true;

        }
        public async Task<GeneralGroupVM> GetGroups(CancellationToken ct = default)
    {
        var groups = await _GroupRepository.GetGroups(ct);
        var users = await _GroupRepository.GetUsers(ct);

        var result = new GeneralGroupVM()
        {
            Groups = _Mapper.Map<List<GroupVMForView>>(groups),
            Users = _Mapper.Map<List<UserInnerVM>>(users)
        };
        return result;
    }
    public async Task<GroupVM> GetGroupById(long id, CancellationToken ct = default)
    {
        var result = await _GroupRepository.GetGroupById(id, ct);
        return _Mapper.Map<Groups, GroupVM>(result);
    }

    public async Task<BaseVM> GetGroupInformation(long id, CancellationToken ct = default)
    {
        var result = await _GroupRepository.GetGroupInformation(id, ct);
        return result;
        }
        public async Task<bool> RemoveUsers(long id, List<long> usersId, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            if (usersId.Count != 0)
            {

                await _GroupRepository.RemoveUsersFromGroup(id, usersId, ct);

            }
            return true;
        }

        public async Task<bool> UpdateGroup(GroupVM groupVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {

            var group = _Mapper.Map<GroupVM, Groups>(groupVM);
            GeneralMethod.AddBaseProperties<Groups>(group, accessor, user, false);
            return await _GroupRepository.UpdateGroup(group, ct);
        }
        public async Task<bool> DeleteGroup(long id, CancellationToken ct = default)
    {
        return await _GroupRepository.DeleteGroup(id, ct);
    }
}
}

