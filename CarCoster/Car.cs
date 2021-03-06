﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CarCoster
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Transmission { get; set; }
        public int? EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public string ElecricEnergyConsumptionMiles { get; set; }
        public string MilesPerKilowatt { get; set; }
        public string MaximumRangeKm { get; set; }
        public string MaximumRangeMiles { get; set; }
        public float? MetricUrbanCold { get; set; }
        public float? MetricExtraUrban { get; set; }
        public float? MetricCombined { get; set; }
        public float? ImperialUrbanCold { get; set; }
        public float? ImperialExtraUrban { get; set; }
        public float? ImperialCombined { get; set; }
        public float? CO2gramsPerKilometer { get; set; }
        public string FuelCostPer12000Miles { get; set; }
        public float? ElectricityCost { get; set; }
        public string CostPer12000Miles { get; set; }
        public int? FuelCostPer6000Miles { get; set; }
        public int? EuroStandard { get; set; }
        public float? NoiseLevelDB { get; set; }
        public float? EmissionCO2 { get; set; }
        public string THCLevel { get; set; }
        public float? NOxEmissions { get; set; }
        public float? THCAndNOxEmissions { get; set; }
        public float? Particulates { get; set; }
        public string blank { get; set; }
        public string carJSONYear { get; set; }
        public float? TaxBand { get; set; }
        public float? ActualCostPer12000Miles { get; set; }
    }
}
