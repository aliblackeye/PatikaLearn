const userFormDOM = document.querySelector("#userForm");
userFormDOM.addEventListener("submit",formHandler)


function formHandler(event){
    event.preventDefault();
    const USER_NAME = document.querySelector("#username");
    const SCORE = document.querySelector("#score");
    
    if(SCORE.value && USER_NAME.value){
        addItem(USER_NAME.value,SCORE.value); // gonderdikten sonra sifirlaniyor
        USER_NAME.value = "";
        SCORE.value = "";
    }

    else{
        alert();
    }
}


const ulDOM = document.querySelector("#liste")

const addItem = (username,score) =>{
    
    let liDOM = document.createElement("li");
    liDOM.innerHTML = `<li class="list-group-item d-flex justify-content-between align-items-center">${username}<span class="badge badge-primary badge-pill">${score}</span></li>`
    ulDOM.appendChild(liDOM);

}

const alertDOM = document.querySelector("#alert")
const alert = () => {
    alertDOM.innerHTML = `<div class="alert alert-danger alert-dismissible fade show" role="alert"><strong>Bilgi girmediniz!</strong> Lütfen boş alanları doldurunuz.<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button></div>`;

}
