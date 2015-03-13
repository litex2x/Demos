using Microsoft.AspNet.SignalR;
using CodePound.Demos.SpaWithSignalR.Hubs;
using CodePound.Demos.SpaWithSignalR.Models;
using System.Linq;

namespace CodePound.Demos.SpaWithSignalR.Services
{
    public class BoardService
    {
        private MessageContext db;

        public BoardService(MessageContext db)
        {
            this.db = db;
        }

        public void NotifyUpdates()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<BoardHub>();

            if(hubContext != null)
            {
                var messages = db.Messages.Take(10).OrderByDescending(x => x.Id).ToList();
                hubContext.Clients.All.updateBoard(messages);
            }
        }
    }
}