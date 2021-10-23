using Facade.Services;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System;

namespace Facade
{
    internal class AmericanShipmentSerializer
    {
        private readonly MassConverter _massConverter;
        private readonly CurrencyConverter _currencyConverter;

        public AmericanShipmentSerializer(MassConverter massConverter, CurrencyConverter currencyConverter)
        {
            _massConverter = massConverter;
            _currencyConverter = currencyConverter;
        }

        public void GenerateJson(Shipment shipment)
        {
            shipment.Freights = shipment.Freights.Select(f => new Freight
                                                                {
                                                                    Weight = _massConverter.FromKgToLbs(f.Weight),
                                                                    Description = f.Description
                                                                }
                                                        ).ToList();

            shipment.Price = _currencyConverter.FromUahToUsd(shipment.Price);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string result = JsonSerializer.Serialize(shipment, options);
            string path = $"D:\\ASP and etc\\DesignPatterns\\Facade\\report_{shipment.Id}.json";
            File.WriteAllText(path, result);

            if (File.Exists(path))
                Console.WriteLine("The file has been written succesfully");
            else
                Console.WriteLine("Error while writing file!");
        }
    }
}
