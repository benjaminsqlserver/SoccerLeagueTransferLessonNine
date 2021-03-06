﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using SoccerLeagueTransferApp.Data;

namespace SoccerLeagueTransferApp.Pages
{
    public partial class ConfirmDeleteGenderComponent
    {

        [Inject]

        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        public async Task CheckUserStatus()//it checks if anonymous user has signed in
        {
            try
            {
                var userState = await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();

                if (userState.User.Claims.Any() && userState.User.IsInRole("SiteAdmin"))// check if user has any claims and see if user belongs to site admin role
                {
                    //do nothing

                }
                else
                {
                    UriHelper.NavigateTo("login");//redirect to login page
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Application Error", "An Error Has Occurred.Please Contact Site Admin", 5000);
            }

        }


        //custom method to delete Gender

        private async Task MuyikDeleteGender()
        {
            try
            {
                await ConData.DeleteGender(GenderID);//passing in page parameter GenderID to DeleteGender method
                UriHelper.NavigateTo("genders", true);
            }
            catch(Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Error On Delete", "An Error Occurred While Deleting Gender Record!", 5000);
            }
        }
    }
}
