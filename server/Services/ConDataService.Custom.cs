using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SoccerLeagueTransferApp.Models.ConData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerLeagueTransferApp
{
    public partial class ConDataService
    {
        //method to validate user
        //takes in two parameters username and password

        public async Task<User> ValidateUser(string username,string password)
        {
            var user = new User();

            var user1 = context.Users.FirstOrDefault(p => p.Username == username && p.Password == password);

            if(user1!=null)
            {
                user = user1;
            }

            return await Task.FromResult(user);

        }

        public async Task<long> MuyikDeleteExistingUserRoles(int userID)
        {
            long rolesCount = 0;

            //get existing user roles from data store

            var existingUserRoles = context.UsersInRoles.Where(p => p.UserID == userID).ToList();
            if(existingUserRoles.Any())//checking if any userroles was returned
            {
                context.UsersInRoles.RemoveRange(existingUserRoles);//command to delete existing user roles
                context.SaveChanges();//persist changes to datastore
            }

            //get fresh count of user roles from data store

            rolesCount = context.UsersInRoles.Where(p => p.UserID == userID).ToList().Count;

            return rolesCount;
        }

        public async Task MuyikResetPassword(int userID, string newPassword)
        {
            var user = context.Users.FirstOrDefault(p => p.UserID == userID);
            if(user.UserID > 0)//this implies that user is not null
            {
                user.Password = newPassword;
                context.SaveChanges();
            }
        }

        public async Task<Role> MuyikGetRoleByName(string roleName)
        {
            var role = new Role();

            try
            {
                var role1 = context.Roles.FirstOrDefault(p => p.RoleName == roleName);
                if(role1!=null && role1.RoleID > 0)
                {
                    role = role1;
                }
            }
            catch(Exception)
            {

            }

            return role;
        }

        public async Task MuyikSaveNewRoleList(List<UsersInRole> usersInRoles)
        {
            context.UsersInRoles.AddRange(usersInRoles);
        }

        public async Task<List<string>> MuyikGetRolesList(int userID)
        {
            var roles = new List<string>();

            var items = context.GetUserRoles.FromSqlRaw("EXEC [dbo].[GetUserRoles] @UserID={0}", userID).ToList();

            if(items.Any())
            {
                foreach(GetUserRole item in items)
                {
                    if(!string.IsNullOrEmpty(item.RoleName))
                    {
                        roles.Add(item.RoleName);
                    }
                }
            }

            return await Task.FromResult(roles);
        }

        public async Task<List<UsersInRole>> MuyikGetExistingUserRoles(int userID)
        {
            var list = new List<UsersInRole>();

            //get existing user roles from data store

            var existingUserRoles = context.UsersInRoles.Include("Role").Where(p => p.UserID == userID).ToList();
            
                list = existingUserRoles;//point existingUserRoles reference to list reference


            return await Task.FromResult(list);
        }

        public async Task<User> MuyikGetUserByEmail(string emailAddress)
        {
            var user = new User();

            var user1 = context.Users.FirstOrDefault(p => p.EmailAddress==emailAddress);

            if (user1 != null)
            {
                user = user1;
            }

            return await Task.FromResult(user);
        }
    }
}
