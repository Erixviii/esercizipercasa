
main()


function main(){       
    for (let index = 0; index < 4; index++) {
        
        switch (index) {
            case 0:
                takeit("charmander",index)
            break;
            case 1:
                takeit("squirtle",index)
            break;
            case 2:
                takeit("turtwig",index)
            break;
            case 3:
                takeit("pikachu",index)
            break;
            default:
                break;
        }
        
    }
}
function takeit(nome:string,index:number){

    fetch(`https://pokeapi.co/api/v2/pokemon/${nome}`)
        .then(response => response.json())
        .then((mon) => {  
            
            if(index==0)
            addHTML(`<h1 style="margin-left:10%">CHOOSE YOUR FIRST POKEMON</h1><br><br>`)

            if(index<3)
            addHTML(` 
                <div class="card" style="display:inline-block;text-align: center;">
                        <img src="${mon.sprites.front_default}" alt="Ma che ca...?" style="width:40%;">
                        <br>
                        <div class="container" style="background-color: rgba(168, 144, 5, 0.534);"><center>
                            <b>Name: </b><br> ${mon.name}<br><br>
                            <b>Elemento: </b><br> ${mon.types[0].type.name}<br><br>
                            <b>Descrizione: </b><br> https://www.pokemon.com/it/pokedex/${mon.name}<br><br>
                        </center></div>
                    </div>&nbsp;
                ` ) 
            if(index==3)
            addHTML(   `
                    <br><br><h1 style="margin-left:30%">or</h1><br><br>
                        <div class="card" style="display:inline-block;text-align: center;margin-left:15%">
                            <img src="${mon.sprites.front_default}" alt="Ma che ca...?" style="width:30%;">
                            <br>
                            <div class="container" style="background-color: rgba(168, 144, 5, 0.534);"><center>
                                <b>Name: </b><br> ${mon.name}<br><br>
                                <b>Elemento: </b><br> ${mon.types[0].type.name}<br><br>
                                <b>Descrizione: </b><br> https://www.pokemon.com/it/pokedex/${mon.name}<br><br>
                            </center></div>
                        </div>`)
         })
}

function addHTML(what:string){

    document.body.innerHTML += what
}


