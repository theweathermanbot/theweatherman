using System;
using Microsoft.Extensions.Hosting;

namespace TheWeatherman.Application.Contract.Service.Background
{
    public interface IBackgroundService: IHostedService, IDisposable
    {
    }
}