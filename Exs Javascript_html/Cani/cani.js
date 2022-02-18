(async () => {
    await  fetch("https://dog.ceo/api/breeds/list/all")
    .then(Response=> Response.json())
    .then(razze => {

        var val=0
        for(var cane in razze.message){

            var option = document.createElement("option");
            option.text = cane;
            option.value = val;
            val++;
            document.getElementById("CMB").add(option);
        }
    });

    var select= document.getElementById("CMB");

    setInterval(() => {
        fetch(`https://dog.ceo/api/breed/${select.options[select.value].text}/images/random`)
            .then(Response=>Response.json())
            .then(source => document.getElementById("IMG").src= source.message)
    }, 3000);
    }) ();
