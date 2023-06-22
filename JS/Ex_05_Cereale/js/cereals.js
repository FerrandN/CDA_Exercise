import {Datas} from "./datas.js";
import {Cereal} from "./cereal.js"

class Cereals
{
    constructor()
    {
        this.cerealsCollection = [];
        this.sortOrder = true;
    }

    async getCereals()
    {
        let cerealToAdd = await Datas.fetchData('https://arfp.github.io/tp/web/frontend/cereals/cereals.json');
        for(let cereal of cerealToAdd.data)
        {
            this.cerealsCollection.push(new Cereal(cereal));
        }
    }

    deleteCereal(id)
    {
        this.cerealsCollection=this.cerealsCollection.filter(cer => cer.id!=id);
    }

}

export {Cereals}