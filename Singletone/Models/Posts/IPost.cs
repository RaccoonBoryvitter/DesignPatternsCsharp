using Singleton.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;



namespace Singleton.Models.Posts
{
    internal interface IPost
    {
        string Id { get; }
        DailyStatistics Statistics { get; }
        void ProcessCargo(CargoVehicle vehicle);
    }
}
