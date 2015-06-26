
var EssentialNamespace = {
    ElementFromInside: function() {
        
    },

    AnotherElementFromInside: function() {
        
    }
};

var Utilities = {
    StringUtilities: {
        PalindromUtility: function() {

            var trainingTest = function(text) {
                return text.length;
            };



            var classBody = {
                Mg: "test",
                Vnth: "vn test",
                Chmura: "cloud test",
                Koziu: "raiden",
                Test: function (text) {
                    trainingTest(text);
                    return true;
                },

                Whatever: function() {
                    console.log('dziedziczenie prototypowe');
                }
            };

            return classBody;
        }
    }
};

var IAmTryingToDerive = function () {

//    return {
//        Mg: "test mg derived"
//    };
};

IAmTryingToDerive.prototype = new Utilities.StringUtilities.PalindromUtility();