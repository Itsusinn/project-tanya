using Tanya.Game.Apex.Core;
using Tanya.Game.Apex.Core.Interfaces;
using System.Net.Http;

namespace Tanya.Game.Apex.Feature.Spectators
{
    public class Feature : IFeature
    {
        private readonly Config _config;
        private int? previousCount;
        private static readonly HttpClient client = new HttpClient();
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
            if (previousCount == null) previousCount = spectatorCount;

            if (spectatorCount > previousCount){
                // try {
                //     client.GetAsync("http://127.0.0.1:3000/beep").GetAwaiter().GetResult();;
                // } catch (Exception) { }
            }
            if (spectatorCount == 0 && previousCount != 0){
                // try {
                //     client.GetAsync("http://127.0.0.1:3000/safe").GetAwaiter().GetResult();;
                // } catch (Exception) { }
            }

            // todo: need to find a better way to alert the user, maybe a Console.Beep()?
            // Console.WriteLine("Spectators: {0}", spectatorCount);
            previousCount = spectatorCount;
        }
        #endregion
    }
}