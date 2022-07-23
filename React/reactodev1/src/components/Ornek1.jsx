import { useState } from "react";


function Ornek1() {
    const [name, setName] = useState("Ali");
    const [age, setAge] = useState(20);
    const [friends, setFriends] = useState(["Berkay","Anıl"]);
    const [address,setAddress]= useState({title:'Istanbul',zip: 34785});


    return (
        <div>
            <h1>İsim: {name} </h1>
            <h1>Yaş: {age}  </h1>
            <button onClick={() => setName("Anıl")}>Adı Değiştir</button>
            <button onClick={() => setAge(30)}>Yaşı Değiştir</button>

            <hr/>

            {
                friends.map((friend,key) => (
                    <div key={key}>{friend}</div>
                ))
            }
            <button onClick={() => setFriends([ "Özgür","Enes", ...friends,])}>Arkadaş Ekle</button>

            <hr/>

            <h2>Address</h2>
            <div>{address.title + " " +address.zip}</div>
            <button onClick={() => setAddress({...address, zip: "34436"})}>
            Adresi Değiştir
            </button>


        </div>

        
    )

}

export default Ornek1;