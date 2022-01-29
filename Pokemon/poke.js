main();
function main() {
    for (var index = 0; index < 4; index++) {
        switch (index) {
            case 0:
                takeit("charmander",index);
                break;
            case 1:
                takeit("squirtle",index);
                break;
            case 2:
                takeit("turtwig",index);
                break;
            case 3:
                takeit("pikachu",index);
                break;
            default:
                break;
        }
    }
}
function takeit(nome, index) {
    fetch("https://pokeapi.co/api/v2/pokemon/" + nome)
        .then(function (response) { return response.json(); })
        .then(function (mon) {
        if (index == 0)
            addHTML("<h1 style=\"margin-left:10%\">CHOOSE YOUR FIRST POKEMON</h1><br><br>");
        if (index < 3)
            addHTML(" \n                <div class=\"card\" style=\"display:inline-block;text-align: center;\">\n                        <img src=\"" + mon.sprites.front_default + "\" alt=\"Ma che ca...?\" style=\"width:40%;\">\n                        <br>\n                        <div class=\"container\" style=\"background-color: rgba(168, 144, 5, 0.534);\"><center>\n                            <b>Name: </b><br> " + mon.name + "<br><br>\n                            <b>Elemento: </b><br> " + mon.types[0].type.name + "<br><br>\n                            <b>Descrizione: </b><br> https://www.pokemon.com/it/pokedex/" + mon.name + "<br><br>\n                        </center></div>\n                    </div>&nbsp;\n                ");
        if (index == 3)
            addHTML("\n                    <br><br><h1 style=\"margin-left:30%\">or</h1><br><br>\n                        <div class=\"card\" style=\"display:inline-block;text-align: center;margin-left:20%\">\n                            <img src=\"" + mon.sprites.front_default + "\" alt=\"Ma che ca...?\" style=\"width:40%;\">\n                            <br>\n                            <div class=\"container\" style=\"background-color: rgba(168, 144, 5, 0.534);\"><center>\n                                <b>Name: </b><br> " + mon.name + "<br><br>\n                                <b>Elemento: </b><br> " + mon.types[0].type.name + "<br><br>\n                                <b>Descrizione: </b><br> https://www.pokemon.com/it/pokedex/" + mon.name + "<br><br>\n                            </center></div>\n                        </div>");
    });
}
function addHTML(what) {
    document.body.innerHTML += what;
}
