var defaultbody;
var logo;
var phrase;
(async ()=>{
    await fetch("https://api.chucknorris.io/jokes/categories")
    .then(Response=>Response.json())
    .then(cat=>{

        for (let index = 1; index < cat.length; index++){
            
            var option = document.createElement("option")
            option.text = cat[index];
            option.value = index;
            document.getElementById("cmb").add(option)   
        }

        defaultbody= document.body.innerHTML
    })
    }) ();

 function Changed(){
    (async () =>{
    var select= document.getElementById("cmb")
    fetch(`https://api.chucknorris.io/jokes/random?category=${select.options[select.value].text}`)
    .then(Response=>Response.json())
    .then(joke=>{
        
        logo = document.createElement("img")
        logo.src= joke.icon_url;
        logo.style="    display: block;margin-left: auto;margin-right: auto;";
        phrase = document.createElement("p")
        phrase.innerHTML= joke.value;
        phrase.id="phrase"

        document.body.innerHTML=defaultbody;
        var loading = document.createElement("div")
        loading.id="Loading"
        loadtext = document.createElement("p")
        loadtext.innerHTML= "LOADING..."
        loadtext.id="loadtext"
        loading.append(loadtext)
        document.body.append(loading)

        setTimeout(()=>{Refresh()},3000)
    })})();
 }

 function Refresh(){

    document.body.innerHTML=defaultbody;
    var card= document.createElement("div")
    card.className="card"
    document.body.append(card)
    card.append(document.createElement("br"))
    card.append(document.createElement("br"))
    card.append(logo)
    card.append(phrase)
 }
