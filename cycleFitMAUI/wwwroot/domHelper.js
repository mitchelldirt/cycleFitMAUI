window.domHelper = {
    removeDisabledAttribute: function () {
        var disabledInputs = document.querySelectorAll('input[disabled]');
        disabledInputs.forEach(function (input) {
            input.removeAttribute('disabled');
        });
    },
    
    addHeartRateData: function (HRData) {
        var HRInputs = document.getElementsByName('HR');

        // Maybe you should actually make the HR data just an array for simplicity so it's easier to apply to the inputs?
        HRInputs[0] = HRData.Zone1.Low;
        HRInputs[1] = HRData.Zone1.High;
        HRInputs[2] = HRData.Zone2.Low;
        HRInputs[3] = HRData.Zone2.High;
        HRInputs[4] = HRData.Zone3.Low;
        HRInputs[5] = HRData.Zone3.High;
        HRInputs[6] = HRData.Zone4.Low;
        HRInputs[7] = HRData.Zone4.High;
        HRInputs[8] = HRData.Zone5.Low;
        HRInputs[9] = HRData.Zone5.High; 
    },

    getHRData: function () {
        var heartRates = document.getElementsByName("HR");
       
        return JSON.stringify({
            Zone1: {
                Low: heartRates[0].value,
                High: heartRates[1].value
            },
            Zone2: {
                Low: heartRates[2].value,
                High: heartRates[3].value
            },
            Zone3: {
                Low: heartRates[4].value,
                High: heartRates[5].value
            },
            Zone4: {
                Low: heartRates[6].value,
                High: heartRates[7].value
            },
            Zone5: {
                Low: heartRates[8].value,
                High: heartRates[9].value
            }
        })
    
     }
};

