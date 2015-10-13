function test(valueConstructor) {
	
	this.valueConstructor = valueConstructor;
	
	this.showMessage = function (message){
		console.log(message);
	};
	
}

var testVar = new test(8);
testVar.showMessage(testVar.valueConstructor);
testVar.showMessage('dupa');