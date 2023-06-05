import { ZipCode } from "./ZipCode.js";
const zipcodes = new ZipCode();


let zipcodeInput = document.getElementById('zipcode');

//console.log(zipcodeInput);
//console.log(zipcodeInput.name);
console.log("coucou");
await zipcodes.load().then(()=>{
    zipcodeInput.addEventListener('keyup',(event) => {
        var reg = new RegExp('^[0-9]{5}$');
        let value = event.target.value;
        var reg2 = new RegExp('^[A-zÀ-ú] *$');
        //console.log("test");
        if(reg.test(value) || reg2.test(value)){
            console.log(value);
            let rt = zipcodes.search(value);
            console.log(rt);
        }
    })
});