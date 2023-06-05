import {ZipCodeClass} from "./ZipCode.js";
const zipcodes = new ZipCodeClass();

let searchBarInput = document.getElementById('searchbar');

await zipcodes.load().then(()=>{
    searchBarInput.addEventListener('keyup',(event) =>{
        var regDigit = new RegExp('^[0-9]{5}$');
        var regLetters = new RegExp('^[A-zÀ-ú ]*$');
        let value = event.target.value;

        if(regDigit.test(value)||regLetters.test(value))
        {
            console.log(value);
            let rt = zipcodes.search(value);
            
            for(let city of rt)
            {
                let li = document.createElement('li');
                li.innerText = city.nomCommune;
                searchBarInput.appendChild(li);
            }

            console.log(rt);
        }
    })
});



