class ZipCodeClass
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
        }
        catch(error)
        {

        }
    }

    search(value)
    {
        let result = this.zipcodes.filter(city => city.codePostal == value || city.nomCommune == value);
        return result;
    }
}
export {ZipCodeClass}