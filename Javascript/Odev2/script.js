const gorevDOM = document.querySelector("#gorev")
const ekleDOM = document.querySelector(".button")
const ulDOM = document.querySelector("#list")

const yeniGorev = () => { // YENI GOREV EKLEME

    let duplicate = true;
    for(let i = 0; i < ulDOM.children.length; i++){     
        if(ulDOM.children.item(i).firstChild.textContent.trim() == gorevDOM.value){
            duplicate = false;
            break;
        }        
    }

    if(gorevDOM.value.trim() && duplicate == true){
        let gorev = gorevDOM.value;
        let liDOM = document.createElement("li");
        liDOM.innerHTML = `${gorev}<span class="close">×</span>`;
        ulDOM.append(liDOM);

    }

}


ulDOM.addEventListener("click",function(event){ //SILME,SECME VE RENKLENDIRME ISLEMLERI
    // event.target.remove()

    if(event.target.parentNode.nodeName == "LI"){ //eger tiklanan objenin etiketi LI ise 
        event.target.parentNode.remove() // LI elementini siler
    }

    else if(event.target.nodeName == "LI" &&  event.target.style.textDecoration == ""){
        event.target.style.textDecoration = "line-through"     
        event.target.style.backgroundColor = "rgb(113, 88, 226)"     
    }

    else if(event.target.nodeName == "LI" &&  event.target.style.textDecoration == "line-through" && event.target.style.backgroundColor == "rgb(113, 88, 226)"){
        event.target.style.textDecoration = "";
        event.target.style.backgroundColor = "";
    }
        
});

