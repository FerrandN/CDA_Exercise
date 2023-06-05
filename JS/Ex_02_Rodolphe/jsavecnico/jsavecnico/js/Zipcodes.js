class Zipcodes{
    constructor(){
        this.datasource = 'https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json';
        this.datas = [];
    }

    async load(){
        try{
            let ressource = await fetch(this.datasource);
            this.datas = await ressource.json();
            return this.datas;
        } catch (error){

        }
    }
}

export {Zipcodes};