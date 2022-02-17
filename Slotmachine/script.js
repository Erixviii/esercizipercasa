let Main= async () => {

    for (let index = 0; index < 15; index++) {
    
        document.getElementById("slot1").src = await Firstmove();

        document.getElementById("slot2").src = await Firstmove();

        document.getElementById("slot3").src = await Firstmove();
    }
}

let Firstmove=  () => {

    return new Promise((resolve) => {

        n = Math.round(Math.random()*10)

        setTimeout(()=> resolve(`./assets/${n}.png`),100);
    })
}
