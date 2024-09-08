 // JavaScript to calculate and display the width
 window.onload = function() {
    var divWidth = document.querySelector('.div1').offsetWidth;
    document.getElementById('pixelValue').textContent = divWidth;
};
window.onresize = function() {
    var divWidth = document.querySelector('.div1').offsetWidth;
    document.getElementById('pixelValue').textContent = divWidth;
};