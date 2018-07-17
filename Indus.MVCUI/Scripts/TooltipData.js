
function JsonToHtmltemplate(result) {
            //var successdata = JSON.parse(result);
            data1 = '<div class="scroll1 scroll"><div class="bg-danger"><center><strong>' + result.SiteEntity.SiteId + '</strong></center></div>' +
                                '<table>' +
                                '<tr><td width="35%">Site&nbsp;Name </td><td>: ' + result.SiteEntity.Name + '</td></tr>' +
                                '<tr><td>Site&nbsp;Status </td><td>: ' + result.SiteEntity.Status + '</td></tr>' +
                                '<tr><td>Address </td><td>: ' + result.SiteEntity.AddressEntity.Line1 + ',' + result.SiteEntity.AddressEntity.TalukMandal + '</td></tr>' +
                                '<tr><td>District </td><td>: ' + result.SiteEntity.AddressEntity.DistrictEntity.Name + '</td></tr>' +
                                '<tr><td>Last Event  </td><td>: ' + result.SiteEventDateTime + '</td></tr>' +
                                '</table>' +
                                '<div><center><b>Alarms</b></center></div>' +
                                '<table border="1" width="100%">' +
                                '<tr style="background-color:#a4a4a4;color:white"><td class="text-center">Alarm Event</td><td class="text-center">Status</td></tr>' +
                                '<tr><td>Shelter Door Open  </td><td width="15%" class="text-center">' + icon_Tooltip2(result.ShelterDoorOpen) + '</td></tr>' +
                                '<tr><td>Fire & Smoke  </td><td width="15%" class="text-center">' + icon_Tooltip2(result.FAndS) + '</td></tr>' +
                                '<tr><td>Room Temperature High  </td><td class="text-center">' + icon_Tooltip2(result.RoomTemperatureHigh) + '</td></tr>' +
                                '<tr><td>Load On DG  </td><td class="text-center">' + icon_Tooltip(result.LoadOnDG) + '</td></tr>' +
                                '<tr><td>DG ManualMode  </td><td class="text-center">' + icon_Tooltip(result.DGManualMode) + '</td></tr>' +
                                '<tr><td>Generator Running  </td><td class="text-center">' + icon_Tooltip(result.GeneratorRunning) + '</td></tr>' +
                                '<tr><td>DG Fuel Low  </td><td class="text-center">' + icon_Tooltip2(result.DGFuelLow) + '</td></tr>' +
                                '<tr><td>DG Stop Mode  </td><td class="text-center">' + icon_Tooltip(result.DGStopMode) + '</td></tr>' +
                                '<tr><td>Load On Mains  </td><td class="text-center">' + icon_Tooltip(result.LoadOnMains) + '</td></tr>' +
                                '<tr><td>Site On Battery  </td><td class="text-center">' + icon_Tooltip(result.SiteOnBattery) + '</td></tr>' +
                                '<tr><td>Generator Alternator Fail  </td><td class="text-center">' + icon_Tooltip2(result.GeneratorAlternatorFail) + '</td></tr>' +
                                '<tr><td>Generator Fail To Start  </td><td class="text-center">' + icon_Tooltip2(result.GeneratorFailToStart) + '</td></tr>' +
                                '<tr><td>Cabinet Temerature High  </td><td class="text-center">' + icon_Tooltip2(result.CabinetTemeratureHigh) + '</td></tr>' +
                                '<tr><td>Mains OverLoad  </td><td class="text-center">' + icon_Tooltip2(result.MainsOverLoad) + '</td></tr>' +
                                '<tr><td>Load On Generator  </td><td class="text-center">' + icon_Tooltip(result.LoadOnGenerator) + '</td></tr>' +
                                '<tr><td>Mains OK  </td><td class="text-center">' + icon_Tooltip(result.MainsOK) + '</td></tr>' +
                                '<tr><td>EB Health  </td><td class="text-center">' + icon_Tooltip(result.EBHealth) + '</td></tr>' +
                                '<tr><td>Generator In AutoMode  </td><td class="text-center">' + icon_Tooltip(result.GeneratorInAutoMode) + '</td></tr>' +
                                '<tr><td>Generator In ManualMode  </td><td class="text-center">' + icon_Tooltip(result.GeneratorInManualMode) + '</td></tr>' +
                                '<tr><td>Mains Fail  </td><td class="text-center">' + icon_Tooltip2(result.MainsFail) + '</td></tr>' +
                                '<tr><td>Generator Common Fault  </td><td class="text-center">' + icon_Tooltip2(result.GeneratorCommonFault) + '</td></tr>' +
                                '<tr><td>HCT Alarm  </td><td class="text-center">' + icon_Tooltip2(result.HCTAlarm) + '</td></tr>' +
                                '<tr><td>Generator Idle Run  </td><td class="text-center">' + icon_Tooltip(result.GeneratorIdleRun) + '</td></tr>' +
                                '<tr><td>Generator Fail To Stop  </td><td class="text-center">' + icon_Tooltip2(result.GeneratorFailToStop) + '</td></tr>' +
                                '<tr><td>LLOP  </td><td class="text-center">' + icon_Tooltip2(result.LLOP) + '</td></tr>' +
                                '<tr><td>Neutral Fail  </td><td class="text-center">' + icon_Tooltip2(result.NeutralFail) + '</td></tr>' +
                                '<tr><td>Generator OverLoad  </td><td class="text-center">' + icon_Tooltip2(result.GeneratorOverLoad) + '</td></tr>' +
                                '<tr><td>Generator MaxRunTime Over  </td><td class="text-center">' + icon_Tooltip(result.GeneratorMaxRunTimeOver) + '</td></tr>' +
                                '<tr><td>Alternator Failed  </td><td class="text-center">' + icon_Tooltip2(result.AlternatorFailed) + '</td></tr>' +
                                '<tr><td>Generator Battery Low  </td><td class="text-center">' + icon_Tooltip2(result.GeneratorBatteryLow) + '</td></tr>' +
                                '<tr><td>Site Battery Low  </td><td class="text-center">' + icon_Tooltip2(result.SiteBatteryLow) + '</td></tr>' +
                                '<tr><td>Tampering  </td><td class="text-center">' + icon_Tooltip2(result.Tampering) + '</td></tr>' +
                                '</table>' +
                                '<div><center><b>Main Voltage (V)</b></center></div>' +
                                '<table border="1" width="100%" class="text-center"><tr class="bg-warning"><td>R</td><td>Y</td><td>B</td></tr><tr><td>' + result.TrimMainsRVoltage + '</td><td>' + result.TrimMainsYVoltage + '</td><td>' + result.TrimMainsBVoltage + '</td></tr></table>' +
                                '<div><center><b>Main Current (Amp)</b></center></div>' +
                                '<table border="1" width="100%" class="text-center">  <tr class="bg-danger"><td>R</td><td>Y</td><td>B</td></tr><tr><td>' + result.TrimMainsRCurrent + '</td>    <td>' + result.TrimMainsYCurrent + '</td>    <td>' + result.TrimMainsBCurrent + '</td>  </tr></table>' +
                                '<div><center><b>Main Frequency (Hz)</b></center></div>' +
                                '<table border="1" width="100%" class="text-center">  <tr class="bg-info"><td>R</td><td>Y</td><td>B</td></tr><tr><td>' + result.MainsRFrequency + '</td>    <td>' + result.MainsYFrequency + '</td>    <td>' + result.MainsBFrequency + '</td>  </tr></table>' +
                                '<div><center><b>Main Power (Kw)</b></center></div>' +
                                '<table border="1" width="100%" class="text-center">  <tr class="bg-success"><td>R</td><td>Y</td><td>B</td></tr><tr><td>' + result.MainsRPhasePower + '</td>    <td>' + result.MainsYPhasePower + '</td>    <td>' + result.MainsBPhasePower + '</td>  </tr></table>' +
                                '<div><center><b>Generator Voltage (V)</b></center></div>' +
                                '<table border="1" width="100%" class="text-center">  <tr class="bg-warning"><td>R</td><td>Y</td><td>B</td></tr><tr><td>' + result.GeneratorRVoltage + '</td>    <td>' + result.GeneratorYVoltage + '</td>    <td>' + result.GeneratorBVoltage + '</td>  </tr></table>' +
                                '<div><center><b>Generator Current (Amp)</b></center></div>' +
                                '<table border="1" width="100%" class="text-center">  <tr class="bg-danger"><td>R</td><td>Y</td><td>B</td></tr><tr><td>' + result.GeneratorRCurrent + '</td>    <td>' + result.GeneratorYCurrent + '</td>    <td>' + result.GeneratorBCurrent + '</td>  </tr></table>' +
                                '<div><center><b>Power Factor</b></center></div>' +
                                '<table border="1" width="100%" class="text-center">  <tr class="bg-info"><td>R</td><td>Y</td><td>B</td></tr><tr><td>' + result.PowerFactorRPhase + '</td>    <td>' + result.PowerFactorYPhase + '</td>    <td>' + result.PowerFactorBPhase + '</td>  </tr></table>' +
                                '<div><center><b>Total Run Hours (Hrs)</b></center></div>' +
                                '<table border="1" width="100%" class="text-center">' +
                                '  <tr style="background-color:#a4a4a4;color:white">    <td>DG</td>    <td>Mains</td>    <td>Battery</td>  </tr>' +
                                '  <tr>    <td>' + result.DGTotalRunMinutes + '</td><td>' + result.MainsTotalRunMinutes + '</td><td>' + result.BatteryTotalRunMinutes + '</td>  </tr>' +
                                '</table>' +
                                '<div><center><b>Others</b></center></div>' +
                                '<table border="1" width="100%">' +
                                '<tr style="background-color:#a4a4a4;color:white"><td class="text-center">Parameter</td><td class="text-center">value</td></tr>' +

                                 '<tr><td>AirconEnergy  </td><td width="15%" class="text-center">' + result.AirconEnergy + '</td></tr>' +
                                '<tr><td>NE Voltage  </td><td class="text-center">' + result.N_EVoltage + '</td></tr>' +
                                '<tr><td>DG Temper RunHrs  </td><td class="text-center">' + result.DGTemperRunHrs + '</td></tr>' +
                                '<tr><td>Gas Meter  </td><td class="text-center">' + result.GasMeter_xxxxxxxx_m3_FromModbusProtocol + '</td></tr>' +

                                '<tr><td>Site Battery Voltage  </td><td width="15%" class="text-center">' + result.SiteBatteryVoltage + '</td></tr>' +
                                '<tr><td>Generator Frequency  </td><td class="text-center">' + result.GeneratorFrequency + '</td></tr>' +
                                '<tr><td>Generator Output Power  </td><td class="text-center">' + result.GeneratorOutputPower + '</td></tr>' +
                                '<tr><td>Room Temperature  </td><td class="text-center">' + result.RoomTemperature + '</td></tr>' +
                                '<tr><td>Generator Battery Voltage  </td><td class="text-center">' + result.GeneratorBatteryVoltage + '</td></tr>' +
                                '<tr><td>Cabinet Temperature  </td><td class="text-center">' + result.CabinetTemperature + '</td></tr>' +
                                '<tr><td>Dg Running Auto Run-Hours  </td><td class="text-center">' + result.DgRunningAutoRunHours + '</td></tr>' +
                                '<tr><td>Dg Running Manual Run-Hours  </td><td class="text-center">' + result.DgRunningManualRunHours + '</td></tr>' +
                                '<tr><td>Generator No Load Run-Hours  </td><td class="text-center">' + result.GeneratorNoLoadRunHours + '</td></tr>' +
                                '<tr><td>Run-Hours Eb3 Phase  </td><td class="text-center">' + result.RunHoursEb3Phase + '</td></tr>' +
                                '<tr><td>Run-Hours Eb2 Phase  </td><td class="text-center">' + result.RunHoursEb2Phase + '</td></tr>' +
                                '<tr><td>Run-Hours Eb1 Phase  </td><td class="text-center">' + result.RunHoursEb1Phase + '</td></tr>' +
                                '<tr><td>Dg On Load Run-Hours  </td><td class="text-center">' + result.DgOnLoadRunHours + '</td></tr>' +
                                '<tr><td>R Phase 90v-140v Run-Hours  </td><td class="text-center">' + result.RPhase90140RunHours + '</td></tr>' +
                                '<tr><td>R Phase 141v-280v Run-Hours  </td><td class="text-center">' + result.RPhase141280RunHours + '</td></tr>' +
                                '<tr><td>R Phase 281v-300v Run-Hours  </td><td class="text-center">' + result.RPhase281300RunHours + '</td></tr>' +
                                '<tr><td>Y Phase 141v-280v Run-Hours  </td><td class="text-center">' + result.YPhase141280RunHours + '</td></tr>' +
                                '<tr><td>Y Phase 281v-300v Run-Hours  </td><td class="text-center">' + result.YPhase281300RunHours + '</td></tr>' +
                                '<tr><td>B Phase 90v-140v Run-Hours  </td><td class="text-center">' + result.BPhase90140RunHours + '</td></tr>' +
                                '<tr><td>Y Phase 90v-140v Run-Hours  </td><td class="text-center">' + result.YPhase90140RunHours + '</td></tr>' +
                                '<tr><td>B Phase 141v-280v Run-Hours  </td><td class="text-center">' + result.BPhase141280RunHours + '</td></tr>' +
                                '<tr><td>B Phase 281v-300v Run-Hours  </td><td class="text-center">' + result.BPhase281300RunHours + '</td></tr>' +
                                '<tr><td>Mains Energy In KWH  </td><td class="text-center">' + result.MainsEneryInKWH + '</td></tr>' +
                                '<tr><td>Dg Energy In KWH  </td><td class="text-center">' + result.DgEneryInKWH + '</td></tr>' +
                                '</table>' +
                                '</div>';
            return data1;
}

function icon_Tooltip(data, type, full, meta) {
    var orderType = data;
    if (orderType) {
        return '<i class="fa fa-circle text-success" aria-hidden="true"></i>';
    } else {
        return '<i class="fa fa-circle" aria-hidden="true" style="color:#a4a4a4"></i>';
    }
}
function icon_Tooltip2(data, type, full, meta) {
    var orderType = data;
    if (orderType) {
        return '<span class="fa fa-circle text-danger"></span>';        
    } else {
        return '<span class="fa fa-circle" style="color:#a4a4a4"></span>';
    }
}
function icon_Tooltip3(data, type, full, meta) {
    var orderType = data;
    if (!orderType) {
        return '<span class="fa fa-circle text-danger"></span>';
    } else {
        return '<span class="fa fa-circle" style="color:#a4a4a4"></span>';
    }
}