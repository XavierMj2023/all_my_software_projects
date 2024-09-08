const box = document.querySelector(".box");

document.addEventListener("keydown", e => {

    console.log("Key pressed:", e.key);

    let keyName = e.key === " " ? "Space" : e.key;
    console.log("Key name:", keyName);

    let keycode1 = e.code;
    console.log(`Length of the key pressed : ${keycode1.length}`)

    for (let i = 0; i < keycode1.length; i++) {

        // Loop over each character of keyCode
        let charCode = keycode1.charCodeAt(i);

        // Get the Unicode code of the character at index i
        console.log("Unicode code of character at index", i, ":", charCode);
    }

    let keyCode = e.code.charCodeAt(1); // Assign the e.code string to keyCode
    console.log(keyCode);


    box.querySelector(".key-code").innerText = keyCode;
    box.querySelector(".key-name").innerText = keyName.toUpperCase();
    box.querySelector(".key span").innerText = keyName;
    box.querySelector(".code span").innerText = keyCode;

    box.classList.add("active");
});
