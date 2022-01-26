"use strict";
main();
function main() {
    fetch('./poke.json')
        .then(response => response.json())
        .then((mon) => {
        addHTML(`<h1 style="margin-left:10%">CHOOSE YOUR FIRST POKEMON</h1><br><br>`);
        for (let index = 1; index < mon.length; index++) {
            addHTML(` 
                    <div class="card" style="display:inline-block;text-align: center;">
                            <img src="${mon[index].variations[0].image}" alt="Ma che ca...?" style="width:40%;">
                            <br>
                            <div class="container" style="background-color: rgba(168, 144, 5, 0.534);"><center>
                                <b>Name: </b><br> ${mon[index].name}<br><br>
                                <b>Elemento: </b><br> ${mon[index].variations[0].types[0]}<br><br>
                                <b>Descrizione: </b><br> ${mon[index].variations[0].description}<br><br>
                            </center></div>
                        </div>&nbsp;
                    `);
        }
        addHTML(`
                    <br><br><h1 style="margin-left:30%">or</h1><br><br>
                        <div class="card" style="display:inline-block;text-align: center;margin-left:15%">
                            <img src="${mon[0].variations[0].image}" alt="Ma che ca...?" style="width:40%;">
                            <br>
                            <div class="container" style="background-color: rgba(168, 144, 5, 0.534);"><center>
                                <b>Name: </b><br> ${mon[0].name}<br><br>
                                <b>Elemento: </b><br> ${mon[0].variations[0].types[0]}<br><br>
                                <b>Descrizione: </b><br> ${mon[0].variations[0].description}<br><br>
                            </center></div>
                        </div>`);
    });
}
function addHTML(what) {
    document.body.innerHTML += what;
}
