﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using SoccerLeagueTransferApp.Models.ConData;
using Microsoft.EntityFrameworkCore;

namespace SoccerLeagueTransferApp.Pages
{
    public partial class EditUsersComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(() => { StateHasChanged(); });
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected ConDataService ConData { get; set; }

        [Parameter]
        public dynamic UserID { get; set; }

        SoccerLeagueTransferApp.Models.ConData.User _user;
        protected SoccerLeagueTransferApp.Models.ConData.User user
        {
            get
            {
                return _user;
            }
            set
            {
                if (!object.Equals(_user, value))
                {
                    _user = value;
                    Reload();
                }
            }
        }

        IEnumerable<SoccerLeagueTransferApp.Models.ConData.ClubDetail> _getClubDetailsResult;
        protected IEnumerable<SoccerLeagueTransferApp.Models.ConData.ClubDetail> getClubDetailsResult
        {
            get
            {
                return _getClubDetailsResult;
            }
            set
            {
                if (!object.Equals(_getClubDetailsResult, value))
                {
                    _getClubDetailsResult = value;
                    Reload();
                }
            }
        }

        IEnumerable<SoccerLeagueTransferApp.Models.ConData.Role> _getRolesResult;
        protected IEnumerable<SoccerLeagueTransferApp.Models.ConData.Role> getRolesResult
        {
            get
            {
                return _getRolesResult;
            }
            set
            {
                if (!object.Equals(_getRolesResult, value))
                {
                    _getRolesResult = value;
                    Reload();
                }
            }
        }

        string _confirmPassword;
        protected string confirmPassword
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                if (!object.Equals(_confirmPassword, value))
                {
                    _confirmPassword = value;
                    Reload();
                }
            }
        }

        IEnumerable<string> _userRoleNames;
        protected IEnumerable<string> userRoleNames
        {
            get
            {
                return _userRoleNames;
            }
            set
            {
                if (!object.Equals(_userRoleNames, value))
                {
                    _userRoleNames = value;
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }

        protected async System.Threading.Tasks.Task Load()
        {
            await CheckUserStatus();

            var conDataGetUserByUserIdResult = await ConData.GetUserByUserId(UserID);
            user = conDataGetUserByUserIdResult;

            var conDataGetClubDetailsResult = await ConData.GetClubDetails();
            getClubDetailsResult = conDataGetClubDetailsResult;

            var conDataGetRolesResult = await ConData.GetRoles();
            getRolesResult = conDataGetRolesResult;

            confirmPassword = "";

            userRoleNames = new List<string>(){};

            await MuyikGetCurrentUserRoles();
        }

        protected async System.Threading.Tasks.Task Form0Submit(SoccerLeagueTransferApp.Models.ConData.User args)
        {
            await MuyikEditUser();
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
