let isim = prompt("İsminiz: ");

(isim== " ") || (isim == null) ? isim = "kullanıcı" : isim= isim.toUpperCase()

document.querySelector("#myName").innerHTML = isim;



function zaman(){
    
    let a= new Date().toLocaleString();
    document.querySelector(".clock").innerHTML=a;
}

setInterval(zaman,1000)