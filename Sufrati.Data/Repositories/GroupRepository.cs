using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Sufrati.Data.Repositories
{

    public class GroupRepository : IGroupRepository
    {
        private readonly SufratiContext _context;
        public GroupRepository(SufratiContext context)
        {
            _context = context;
        }
        public async Task<bool> RemoveUsersFromGroup(long id, List<long> usersId, CancellationToken ct = default)
        {
            var result = await _context.UserGroup
                            .Where(p => p.GroupID == id && usersId.Contains(p.UserID))
                            .ToListAsync();
            _context.UserGroup.RemoveRange(result);
            await _context.SaveChangesAsync(ct);
            return true;
        }
        public async Task<Groups> AddGroup(Groups input, List<User> users, IHttpContextAccessor accessor, CancellationToken ct = default)
        {
            try
            {
                _context.Groups.Add(input);
                await _context.SaveChangesAsync(ct);

                //Now Add Group Users if exsist
                if (users.Count != 0)
                {
                    await AddGroupUsers(input.ID, users.Select(u => u.ID).ToList(), true, ct);
                }
            }
            catch(Exception ex)
            {

            }

            return input;
        }
        public async Task<bool> AddUsersForGroup(List<UserGroup> userGroups, CancellationToken ct = default)
        {
            _context.UserGroup.AddRange(userGroups);
            await _context.SaveChangesAsync(ct);
            return true;
        }
        private async Task AddGroupUsers(long groupId, List<long> usersId, bool isAdd, CancellationToken ct = default)
        {
            if (isAdd)
            {
                //get users if exsit or just join them with the group for fisrt time
                var userGroups = GetGroupUsers(usersId, groupId);

                //Now Excute Insertion On Database 
                await DBAddUsersToGroup(userGroups, ct);
            }
            else
            {
                //This means Update Operation
                //Either there is previousely add users or this is the first add
                //Check if GroupId is already exsist
                var userGroup = await _context.UserGroup.Where(ug => ug.GroupID == groupId).ToListAsync(ct);
                if (userGroup.Count != 0)
                {
                    //delete privouse added users within group
                    _context.UserGroup.RemoveRange(userGroup);
                    await _context.SaveChangesAsync(ct);
                }
                var usersWithinGroup = GetGroupUsers(usersId, groupId);
                //Now Excute Insertion On Database 
                await DBAddUsersToGroup(usersWithinGroup, ct);

            }
        }
        private List<UserGroup> GetGroupUsers(List<long> usersId, long groupId)
        {
            List<UserGroup> userGroups = new List<UserGroup>();

            foreach (var userId in usersId)
            {
                UserGroup user_Group = new UserGroup()
                {
                    UserID = userId,
                    GroupID = groupId
                };

                //Add userGroup single object to the general List
                userGroups.Add(user_Group);
            }
            return userGroups;
        }
        private async Task DBAddUsersToGroup(List<UserGroup> userGroups, CancellationToken ct = default)
        {
            //Now Excute Insertion On Database 
            _context.UserGroup.AddRange(userGroups);
            await _context.SaveChangesAsync(ct);
        }


        public async Task<bool> DeleteGroup(long id, CancellationToken ct = default)
        {
            var Obj = await GetGroupById(id, ct);
            _context.Groups.Remove(Obj);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<Groups> GetGroupById(long id, CancellationToken ct = default)
        {
            var result = await _context.Groups.Include(g => g.UserGroups).SingleOrDefaultAsync(b => b.ID == id);
            return result;
        }

        public async Task<BaseVM> GetGroupInformation(long id, CancellationToken ct)
        {
            var result = await _context.Groups.FindAsync(id);
            return await GeneralMethod.GenerateInfoModel(result, _context);
        }

        public async Task<List<Groups>> GetGroups(CancellationToken ct = default)
        {
            return await _context.Groups.ToListAsync(ct);
        }

        public async Task<List<User>> GetUsers(CancellationToken ct = default)
        {
            return await _context.User.ToListAsync(ct);
        }
        public async Task<bool> UpdateGroup(Groups group, CancellationToken ct = default)
        {
            var update = await _context.Groups.FirstAsync(g => g.ID == group.ID);
            group.CreatedByID = update.CreatedByID;
            group.CreatedDate = update.CreatedDate;

            _context.Entry(update).CurrentValues.SetValues(group);
            await _context.SaveChangesAsync();

            //Now Add Group Users if exsist
            //if (users.Count != 0)
            //{
            //    await AddGroupUsers(group.ID, users.Select(u => u.ID).ToList(), false, ct);
            //}

            return true;
        }
    }
}