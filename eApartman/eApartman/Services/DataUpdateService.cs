using eApartman.Database;
using eApartman.Model.Requests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class DataUpdateService : BackgroundService
    {
        private readonly ILogger<DataUpdateService> _logger;
        private readonly IServiceProvider _serviceProvider;
        //private readonly IRezervacijeService _serviceRezervacije;
        public DataUpdateService(ILogger<DataUpdateService> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (IServiceScope scope = _serviceProvider.CreateScope())
            {
                IRezervacijeService _serviceRezervacije =
                    scope.ServiceProvider.GetRequiredService<IRezervacijeService>();

                await _serviceRezervacije.UpdateStatus();
            }
            _logger.LogInformation($"Aplikacija pokrenuta {DateTime.Now}");

            while (!stoppingToken.IsCancellationRequested)
            {
                if (DateTime.Now.Hour == 12 && DateTime.Now.Minute == 0)
                {
                    using (IServiceScope scope = _serviceProvider.CreateScope())
                    {
                        IRezervacijeService _serviceRezervacije =
                            scope.ServiceProvider.GetRequiredService<IRezervacijeService>();

                        await _serviceRezervacije.UpdateStatus();
                    }

                    _logger.LogInformation($"Status rezervacija kojima je checkout na dan {DateTime.Now.ToString("d.M.yyyy")}");
                }
            }
        }
    }
}
