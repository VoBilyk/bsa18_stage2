﻿using System;
using System.Collections.Generic;

namespace Stage2
{
    static class Settings
    {
        static public readonly Dictionary<CarType, decimal> parkingPrices = new Dictionary<CarType, decimal>()
        {
            {CarType.Motorcycle, 1},
            {CarType.Passenger, 3},
            {CarType.Truck, 5},
            {CarType.Bus, 2}
        };

        static public int Timeout { get; private set; } = 3;

        static public int ParkingSpaces { get; private set; }

        static public decimal Fine { get; private set; }

    }
}
