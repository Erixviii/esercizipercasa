main()

function main()
{
    var cane=0
    fetch('https://dog.ceo/api/breeds/list/all')
        .then(Response => Response.json())
        .then(razze => { console.log(typeof razze.message)
            
            for (let index = 0; index < razze.message.length; index++) {
                
                document.getElementById("cani").append('<option>'+  razze.message[index] +'</option>');
        
            }
        })
}


