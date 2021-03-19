using BlazorWebAssemblySignalRApp.Client.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblySignalRApp.Client.Pages
{
    public partial class Notification
    {
        
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        //[Inject]
        //public ILogger<NotificationSubscription> Logger { get; set; }
        protected async override void OnAfterRender(bool firstRender)
        {
           base.OnAfterRender(firstRender);
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("customAlert.init");
              //  var subscription = await JSRuntime.InvokeAsync<NotificationSubscription>("blazorPushNotifications.requestSubscription");
               // var subscription = await JSRuntime.InvokeAsync<NotificationSubscription>("requestSubscription");
              //  Logger.LogInformation($"Url: { subscription.Url} Auth: {subscription.Auth} P256db: {subscription.P256dh}");
            }

        }
    }
}
