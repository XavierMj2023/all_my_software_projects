function textToSpeechExec(){

    var input = document.getElementById("text");

    var textInput = input.value;

    console.log(textInput);

    const utterance = new SpeechSynthesisUtterance(textInput);

    window.speechSynthesis.speak(utterance);
}