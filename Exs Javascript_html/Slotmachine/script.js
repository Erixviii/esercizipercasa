let slot1;
let slot2;
let slot3;

let Main= async () => {
    
    slot1 = document.getElementById("slot1").src;

    slot2 = document.getElementById("slot2").src;

    slot3 = document.getElementById("slot3").src;

    for (let index = 0; index < 15; index++) {
    
        slot1 = await Firstmove();

        slot2 = await Firstmove();

        slot3 = await Firstmove();
    }
    
    document.getElementById("win").style.display="block";
    document.getElementById("win_img").src= Wincheck();
}

let Wincheck= () => {

    let count=1;

    if (slot1 == slot2) {
        
        count++;
        
        if(slot1==slot3){

            count++;
        }
    }
    else if(slot1==slot3){

        count++;
    }

    let win="";
        
    if(count > 1){
        if(count == 3)
            document.getElementById("jackpot").style.display="block";
        else 
            document.getElementById("nice").style.display="block";
    }
    else
        document.getElementById("retry").style.display="block";

    return win;
}

let Firstmove=  () => {

    return new Promise((resolve) => {

        n = Math.round(Math.random()*10)

        setTimeout(()=> resolve(`./assets/${n}.png`),100);
    })
}
