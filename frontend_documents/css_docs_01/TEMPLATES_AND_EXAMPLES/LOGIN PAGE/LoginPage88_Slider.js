    //This is for applying js on Login Form
    var x=document.getElementById("login");

    //This is for applying js on Registrtaion Form
    var y=document.getElementById("register");

    //This is for applying js on button on form button
    var z=document.getElementById("btn");

    //This is the function for Regstration.
    function Register()
    {
        // x.style.left="-900px";
        // It ran away from the screen towards the left side.
        x.style.left="-500px";

        y.style.left="50px";

        z.style.left="110px";
    }

    //This is the function for Login.
    function Login()
    {
        x.style.left="50px";

        y.style.left="450px";

        z.style.left="0";
    }
