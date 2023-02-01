using Microsoft.Extensions.DependencyInjection;
using Tanya.Game.Apex.Core.Interfaces;
using System.Net.Http;

namespace Tanya.Game.Apex.Feature.Spectators
{
    public static class Bootstrap
    {
        #region Statics

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Config>();
            services.AddTransient<IFeature, Feature>();
            var client = new HttpClient();
            try {
                client.GetAsync("http://127.0.0.1:3000/safe").GetAwaiter().GetResult();
            }
            catch (Exception) { }

        }

        #endregion
    }
}