let Main= async () => {

    document.getElementById("win").style.display="none";

    for (let index = 0; index < 15; index++) {
    
        document.getElementById("slot1").src = await Firstmove();

        document.getElementById("slot2").src = await Firstmove();

        document.getElementById("slot3").src = await Firstmove();
    }

    document.getElementById("win").style.display="block";
    
    document.getElementById("win_img").src= Wincheck();
}

let Wincheck= () => {

    let slot1 = document.getElementById("slot1").src;

    let slot2 = document.getElementById("slot2").src;

    let slot3 = document.getElementById("slot3").src;

    let count=1;

    if (slot1 === slot2)
        count++;
    if (slot1 === slot3)
        count++;
    if (slot2 === slot3) 
        count++;

    let win="";
        
    if(count > 1){
        if(count >= 3)
            win= "./assets/jackpot.png";
        else 
            win= "./assets/nice.png";
    }
    else
        win= "./assets/retry.png";

    console.log(slot1+ ", "+ slot2+", "+slot3+"= "+count)
    return win;
}

let Firstmove=  () => {

    return new Promise((resolve) => {

        let max = Math.round(Math.random()*10);
        let min=0;

        if(max>2)
            min=max-3;

        n = Math.round(Math.random() * (max - min) + min) //per aumentare le probabilità

        setTimeout(()=> resolve(`./assets/${n}.png`),100);
    })
}
