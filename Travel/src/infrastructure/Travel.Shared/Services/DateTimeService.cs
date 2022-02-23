using System;
using Travel.Application.Common.Interfaces;

namespace Travel.Shared.Services
{
    public class DateTimeService : IDateTime
    {
        DateTime IDateTime.NowUtc()
        {
            return DateTime.UtcNow;
        }
    }
}