﻿using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public interface ITemperatureRepository : IDisposable
    {
        IEnumerable<Temperature> GetTemperatures();
        Temperature GetTemperatureById(int temperatureId);
        void InsertTemperature(Temperature temperature);
        void DeleteTemperature(int temperatureId);
        void UpdateTemperature(Temperature temperature);
        void Save();
        double Average();
        IEnumerable<Device> GetDevices();
        Device GetDeviceById(int id);
        List<Device> GetAverages();
        List<ChartData> GetWeekChart(Device device);
    }
}