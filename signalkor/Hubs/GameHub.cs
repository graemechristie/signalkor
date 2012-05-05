using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace signalkor.Hubs
{
    public class GameHub : Hub
    {
        static List<PlayerInfo> PlayerPositions = new List<PlayerInfo>();

        public void MoveTo(string player, int x, int y)
        {
            var playerPosition = PlayerPositions.FirstOrDefault(pp=>pp.player == player);
            if (playerPosition == null)
            {
                PlayerPositions.Add(new PlayerInfo { player=player, x = x, y = y });
            } else {
                playerPosition.x = x;
                playerPosition.y = y;
            }
            Clients.updatePlayerPositions(PlayerPositions);
        }

        public void GetPlayerPositions()
        {
            Clients.updatePlayerPositions(PlayerPositions);
        }
    }

    public class PlayerInfo
    {
        public string player { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}