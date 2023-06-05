class ZipCode
{
    constructor()
    {
        this.datasource = "https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json";
        this.zipcodes = [];
    }

    async load()
    {
        try
        {
            let response = await fetch(this.datasource);
            this.zipcodes = await response.json();
            //console.log(this.zipcodes);
            //console.log(this.zipcodes[0]);
        } catch(error)
        {

        }

    }

    search(zipcodes)
    {
        let result = this.zipcodes.filter(city => city.codePostal == zipcode);
        //console.log(result);
        //this.fillUI(result);
        return result;
    }

    searchName(zipcode)
    {
        let nameResult = [];

        nameResult = this.zipcodes.filter(city => city.nomCommune == zipcode)
        //console.log(nameResult);
        this.fillUiName(nameResult);
    }

    fillUi(result)
    {
        let element = document.getElementById('result');
        element.innerHTML ="";

        for(let city of result)
        {
            let li = document.createElement('li');
            li.innerText = city.nomCommune;
            element.appendChild(li);
        }
    }
}
export {ZipCode}