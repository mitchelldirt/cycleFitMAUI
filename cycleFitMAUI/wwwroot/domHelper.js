window.domHelper = {
    removeReadOnlyAttribute: function () {
        var readonlyInputs = document.querySelectorAll('input[readonly]');
        readonlyInputs.forEach(function (input) {
            input.removeAttribute('readonly');
        });
    },
    
    addHeartRateData: function (HRData) {
        var HRInputs = document.getElementsByName('HR');
        // Maybe you should actually make the HR data just an array for simplicity so it's easier to apply to the inputs?
        HRInputs[0].value = HRData.zone1.low;
        HRInputs[1].value = HRData.zone1.high;
        HRInputs[2].value = HRData.zone2.low;
        HRInputs[3].value = HRData.zone2.high;
        HRInputs[4].value = HRData.zone3.low;
        HRInputs[5].value = HRData.zone3.high;
        HRInputs[6].value = HRData.zone4.low;
        HRInputs[7].value = HRData.zone4.high;
        HRInputs[8].value = HRData.zone5.low;
        HRInputs[9].value = HRData.zone5.high; 
    },

    getHRData: function () {
        document.querySelector("#saveHRSpinner").classList.remove("hidden");

        var heartRates = document.getElementsByName("HR");
       
        let HRData = JSON.stringify({
            Zone1: {
                Low: Number(heartRates[0].value),
                High: Number(heartRates[1].value)
            },
            Zone2: {
                Low: Number(heartRates[2].value),
                    High: Number(heartRates[3].value)
            },
            Zone3: {
                Low: Number(heartRates[4].value),
                    High: Number(heartRates[5].value)
            },
            Zone4: {
                Low: Number(heartRates[6].value),
                    High: Number(heartRates[7].value)
            },
            Zone5: {
                Low: Number(heartRates[8].value),
                    High: Number(heartRates[9].value)
            }
        })

        setTimeout(() => {
            document.querySelector("#saveHRSpinner").classList.add("hidden");
        }, 2000);

        return HRData;
     }
};

