const menu = [
  {
    id: 1,
    title: "Çiğ Köfte Dürüm",
    category: "Çiğ Köfte",
    price: "15₺",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/cig-kofte-durumthumb/cig-kofte-durumthumb.jpg",
    desc: ``,
  },
  {
    id: 2,
    title: "Mega Çiğ Köfte Dürüm",
    category: "Çiğ Köfte",
    price: "20₺",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/cig-kofte-mega-durumthumb/cig-kofte-mega-durumthumb.jpg",
    desc: ``,
  },
  {
    id: 3,
    title: "Ultra Mega Çiğ Köfte Dürüm",
    category: "Çiğ Köfte",
    price: "25₺",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/ultra-mega-durumthumb/ultra-mega-durumthumb.jpg",
    desc: ``,
  },
  {
    id: 4,
    title: "Doritoslu Çiğ Köfte Dürüm",
    category: "Çiğ Köfte",
    price: "4₺ fark ile",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/274d9762thumb/274d9762thumb.jpg",
    desc: `Seçtiğiniz tüm dürümlere 4₺ fark ile Doritos ekletebilirsiniz.`,
  },
  {
    id: 5,
    title: "Ekstra 100gr Çiğ Köfte",
    category: "Çiğ Köfte",
    price: "5₺ fark ile",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/299a66fathumb/299a66fathumb.jpg",
    desc: `Aldığınız porsiyona 5₺ fark ile 100gr daha fazla çiğ köfte alabilirsiniz.`,
  },
  {
    id: 6,
    title: "Danette Çikolatalı/Fındıklı",
    category: "Tatlılar",
    price: "3₺",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/9638e59dthumb/9638e59dthumb.jpg",
    desc: `100gr Danette`,
  },
  {
    id: 7,
    title: "Kemalpaşa Tatlısı",
    category: "Tatlılar",
    price: "7₺",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/kemalpasathumb/kemalpasathumb.jpg",
    desc: ``,
  },
  {
    id: 8,
    title: "İrmik Helvası",
    category: "Tatlılar",
    price: "15₺",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/irmik-helvasi-250-grthumb/irmik-helvasi-250-grthumb.jpg",
    desc: `250gr İrmik Helvası`,
  },
  {
    id: 9,
    title: "Fırın Sütlaç",
    category: "Tatlılar",
    price: "15₺",
    img:
      "https://www.komagene.com.tr/Content/Images/Products/firin-sutlacthumb/firin-sutlacthumb.jpg",
    desc: ``,
  },
];

const butonAlani = document.querySelector(".btn-container");
const urunAlani = document.querySelector(".section-center");

tumunuGoster();

const butonOlustrucu = (butonAdi) => {
  let buton = `<button type="button" id="${butonAdi}" class="btn btn-outline-dark btn-item">${butonAdi}</button>`
  return buton;  
}

const butonEkleyici = () => {
  butonAlani.innerHTML = butonOlustrucu("Hepsi") + " " + butonOlustrucu("Çiğköfte") + " " + butonOlustrucu("Tatlı");
}

butonEkleyici(); // Butonlar eklendi.

function tumunuGoster(){
  let menudekiler = "";
  menu.map(yemek => { menudekiler+=yemekOlustur(yemek)})
  urunAlani.innerHTML = menudekiler;
}

let tatliGoster = () => {

  let menudekiler = "";
  menu.map(yemek => {

    if(yemek.category == "Tatlılar"){
      menudekiler+=yemekOlustur(yemek)
    }
  })
  urunAlani.innerHTML = menudekiler;

}

let cigkofteGoster = () => {
  let menudekiler = ""
  menu.map(yemek => {
    if(yemek.category == "Çiğ Köfte"){
      menudekiler += yemekOlustur(yemek);
    }
  })
  urunAlani.innerHTML = menudekiler;
}


const tumuButonu = document.querySelector("#Hepsi").addEventListener("click", tumunuGoster);

const tatliButonu = document.querySelector("#Tatlı").addEventListener("click",tatliGoster);

const cigkofteButonu = document.querySelector("#Çiğköfte").addEventListener("click",cigkofteGoster);

function yemekOlustur(yemek){
  let eklenecekyemek =`
  <div class="menu-items col-sm-12 col-lg-6 ">
    <img class="photo" src="${yemek.img}">
    <div class="menu-info">
      <div class="menu-title">
        <h4>${yemek.title}</h4>
        <h4 class="price">${yemek.price}</h4>
      </div>
      <div class="menu-text">
        ${yemek.desc}
      </div>
    </div>
  </div>

  `;
  return eklenecekyemek;

}