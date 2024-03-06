using Microsoft.AspNetCore.SignalR;

namespace ASP_NETCore_RazorPages
{
    public class HubServer: Hub
    {
        public void RefreshData()
        {
            Clients.All.SendAsync("ReloadData");
        }
    }
}
