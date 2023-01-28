using Tanya.Game.Apex.Core;
using Tanya.Game.Apex.Core.Interfaces;

namespace Tanya.Game.Apex.Feature.Spectators
{
    public class Feature : IFeature
    {
        private readonly Config _config;
        
        #region Constructors

        public Feature(Config config)
        {
            _config = config;
        }

        #endregion

        #region Implementation of IFeature
        public void Tick(DateTime frameTime, State state)
        {
            var spectatorCount = 0;
            
            if (!state.Players.TryGetValue(state.LocalPlayer, out var localPlayer)) return;
            foreach (var (_, player) in state.Players)
            {
                if (player.FYaw - localPlayer.FYaw == 0)
                    spectatorCount++;
            }
            
            // todo: need to find a better way to alert the user, maybe a Console.Beep()? 
            Console.WriteLine("Spectators: {0}", spectatorCount - 1);
        }
        #endregion
    }
}