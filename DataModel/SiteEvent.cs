//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiteEvent
    {
        public SiteEvent()
        {
            this.DailySiteEvents = new HashSet<DailySiteEvent>();
            this.LatestSiteEvents = new HashSet<LatestSiteEvent>();
            this.MonthlySiteEvents = new HashSet<MonthlySiteEvent>();
            this.QuarterlySiteEvents = new HashSet<QuarterlySiteEvent>();
            this.SiteAlarmEvents = new HashSet<SiteAlarmEvent>();
            this.WeeklySiteEvents = new HashSet<WeeklySiteEvent>();
        }
    
        public int Id { get; set; }
        public System.DateTime EventDateTime { get; set; }
        public int SiteId { get; set; }
        public int ProductDetails { get; set; }
        public int SerialNumber { get; set; }
        public int TimeStamp { get; set; }
        public decimal MainsRVoltage { get; set; }
        public decimal MainsRCurrent { get; set; }
        public bool ShowMainsRCurrentInPercentage { get; set; }
        public decimal MainsRFrequency { get; set; }
        public bool EnableMainsRFrequencyHigh { get; set; }
        public bool EnableMainsRFrequencyLow { get; set; }
        public bool EnableMainsRHigh { get; set; }
        public bool EnableMainsRLow { get; set; }
        public bool EnableMainsRok { get; set; }
        public bool IsMainsRFrequencyHigh { get; set; }
        public bool IsMainsRFrequencyLow { get; set; }
        public bool IsMainsRHigh { get; set; }
        public bool IsMainsRLow { get; set; }
        public bool IsMainsRok { get; set; }
        public decimal MainsYVoltage { get; set; }
        public decimal MainsYCurrent { get; set; }
        public bool ShowMainsYCurrentInPercentage { get; set; }
        public decimal MainsYFrequency { get; set; }
        public bool EnableMainsYFrequencyHigh { get; set; }
        public bool EnableMainsYFrequencyLow { get; set; }
        public bool EnableMainsYHigh { get; set; }
        public bool EnableMainsYLow { get; set; }
        public bool EnableMainsYok { get; set; }
        public bool IsMainsYFrequencyHigh { get; set; }
        public bool IsMainsYFrequencyLow { get; set; }
        public bool IsMainsYHigh { get; set; }
        public bool IsMainsYLow { get; set; }
        public bool IsMainsYok { get; set; }
        public decimal MainsBVoltage { get; set; }
        public decimal MainsBCurrent { get; set; }
        public bool ShowMainsBCurrentInPercentage { get; set; }
        public decimal MainsBFrequency { get; set; }
        public bool EnableMainsBFrequencyHigh { get; set; }
        public bool EnableMainsBFrequencyLow { get; set; }
        public bool EnableMainsBHigh { get; set; }
        public bool EnableMainsBLow { get; set; }
        public bool EnableMainsBok { get; set; }
        public bool IsMainsBFrequencyHigh { get; set; }
        public bool IsMainsBFrequencyLow { get; set; }
        public bool IsMainsBHigh { get; set; }
        public bool IsMainsBLow { get; set; }
        public bool IsMainsBok { get; set; }
        public decimal InverterRVoltage { get; set; }
        public decimal InverterRCurrent { get; set; }
        public bool ShowInverterRCurrentInPercentage { get; set; }
        public decimal InverterRFrequency { get; set; }
        public bool EnableInverterRFrequencyHigh { get; set; }
        public bool EnableInverterRFrequencyLow { get; set; }
        public bool EnableInverterRHigh { get; set; }
        public bool EnableInverterRLow { get; set; }
        public bool EnableInverterRok { get; set; }
        public bool IsInverterRFrequencyHigh { get; set; }
        public bool IsInverterRFrequencyLow { get; set; }
        public bool IsInverterRHigh { get; set; }
        public bool IsInverterRLow { get; set; }
        public bool IsInverterRok { get; set; }
        public decimal InverterYVoltage { get; set; }
        public decimal InverterYCurrent { get; set; }
        public bool ShowInverterYCurrentInPercentage { get; set; }
        public decimal InverterYFrequency { get; set; }
        public bool EnableInverterYFrequencyHigh { get; set; }
        public bool EnableInverterYFrequencyLow { get; set; }
        public bool EnableInverterYHigh { get; set; }
        public bool EnableInverterYLow { get; set; }
        public bool EnableInverterYok { get; set; }
        public bool IsInverterYFrequencyHigh { get; set; }
        public bool IsInverterYFrequencyLow { get; set; }
        public bool IsInverterYHigh { get; set; }
        public bool IsInverterYLow { get; set; }
        public bool IsInverterYok { get; set; }
        public decimal InverterBVoltage { get; set; }
        public decimal InverterBCurrent { get; set; }
        public bool ShowInverterBCurrentInPercentage { get; set; }
        public decimal InverterBFrequency { get; set; }
        public bool EnableInverterBFrequencyHigh { get; set; }
        public bool EnableInverterBFrequencyLow { get; set; }
        public bool EnableInverterBHigh { get; set; }
        public bool EnableInverterBLow { get; set; }
        public bool EnableInverterBok { get; set; }
        public bool IsInverterBFrequencyHigh { get; set; }
        public bool IsInverterBFrequencyLow { get; set; }
        public bool IsInverterBHigh { get; set; }
        public bool IsInverterBLow { get; set; }
        public bool IsInverterBok { get; set; }
        public decimal BatteryVoltage { get; set; }
        public decimal BatterySolarChargingCurrent { get; set; }
        public decimal BatteryGridChargingCurrent { get; set; }
        public decimal BatteryDischargingCurrent { get; set; }
        public bool EnableBatterySolarChargerOn { get; set; }
        public bool EnableBatteryGridChargerOn { get; set; }
        public bool EnableBatteryDischargingOn { get; set; }
        public bool EnableBatteryHigh { get; set; }
        public bool EnableBatteryLow { get; set; }
        public bool EnableBatteryOk { get; set; }
        public bool IsBatterySolarChargerOn { get; set; }
        public bool IsBatteryGridChargerOn { get; set; }
        public bool IsBatteryDischargingOn { get; set; }
        public bool IsBatteryHigh { get; set; }
        public bool IsBatteryLow { get; set; }
        public bool IsBatteryOk { get; set; }
        public decimal SolarVoltage { get; set; }
        public decimal SolarCurrent { get; set; }
        public decimal SolarGeneration { get; set; }
        public bool EnableSolarOverCurrent { get; set; }
        public bool EnableSolarHigh { get; set; }
        public bool EnableSolarLow { get; set; }
        public bool EnableSolarOk { get; set; }
        public bool IsSolarOverCurrent { get; set; }
        public bool IsSolarHigh { get; set; }
        public bool IsSolarLow { get; set; }
        public bool IsSolarOk { get; set; }
        public bool EnableInverterBled { get; set; }
        public bool EnableInverterYled { get; set; }
        public bool EnableInverterRled { get; set; }
        public bool EnableMainsBled { get; set; }
        public bool EnableMainsYled { get; set; }
        public bool EnableMainsRled { get; set; }
        public bool IsInverterBled { get; set; }
        public bool IsInverterYled { get; set; }
        public bool IsInverterRled { get; set; }
        public bool IsMainsBled { get; set; }
        public bool IsMainsYled { get; set; }
        public bool IsMainsRled { get; set; }
        public bool EnableBatteryFaultLed { get; set; }
        public bool EnableLoadFaultLed { get; set; }
        public bool EnableSolarChargerLed { get; set; }
        public bool EnableGridChargerLed { get; set; }
        public bool IsBatteryFaultLed { get; set; }
        public bool IsLoadFaultLed { get; set; }
        public bool IsSolarChargerLed { get; set; }
        public bool IsGridChargerLed { get; set; }
    
        public virtual ICollection<DailySiteEvent> DailySiteEvents { get; set; }
        public virtual ICollection<LatestSiteEvent> LatestSiteEvents { get; set; }
        public virtual ICollection<MonthlySiteEvent> MonthlySiteEvents { get; set; }
        public virtual ICollection<QuarterlySiteEvent> QuarterlySiteEvents { get; set; }
        public virtual Site Site { get; set; }
        public virtual ICollection<SiteAlarmEvent> SiteAlarmEvents { get; set; }
        public virtual ICollection<WeeklySiteEvent> WeeklySiteEvents { get; set; }
    }
}
