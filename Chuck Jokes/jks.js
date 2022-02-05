(async ()=>{
    await fetch("https://api.chucknorris.io/jokes/categories")
    .then(Response=>Response.json())
    .then(cat=>{

        console.log(cat[0])
        for (let index = 1; index < cat.length; index++){
            
            var option = document.createElement("option")
            option.text = cat[index];
            option.value = index;
            document.getElementById("cmb").add(option)   
        }
    })
    }) ();

 function Changed(){
    
    var select= document.getElementById("cmb")
    fetch(`https://api.chucknorris.io/jokes/random?category=${select.options[select.value].text}`)
    .then(Response=>Response.json())
    .then(joke=>{
        
        var logo = document.createElement("img")
        logo.src= joke.icon_url;
        logo.style="    display: block;margin-left: auto;margin-right: auto;";
        var phrase = document.createElement("p")
        phrase.innerHTML= joke.value;
        phrase.style="text-align: center;color:white;"

        setTimeout(()=>{
            document.body.append(logo)
            document.body.append(phrase)
        
        },2000) 
    })
 }
