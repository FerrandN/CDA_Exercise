import {Cereal} from "./cereal.js";
import {Data} from "./data.js";

class Cereals
{
    constructor()
    {
        this.cerealCollection = [];
        this.cerealsCollectionCopy = [];
        this.sortedAsc = true;
    }

    async loadData()
    {
        let temp = await Data.getDB('https://arfp.github.io/tp/web/frontend/cereals/cereals.json');
        this.cerealCollection = temp["data"];
        this.cerealCollection = this.cerealCollection.map(c=>new Cereal(c));
        this.cerealsCollectionCopy = Array.from(this.cerealCollection);
    }

    sortByCalories()
    {
        this.cerealsCollectionCopy = this.cerealsCollectionCopy.sort(
            (a,b) => a.calories - b.calories
        )

            if(!this.sortedAsc)
            {
                this.cerealsCollectionCopy.reverse()
            }

        this.sortedAsc = !this.sortedAsc;
    }

    sortByProtein()
    {
        this.cerealsCollectionCopy = this.cerealsCollectionCopy.sort(
            (a,b) => a.protein - b.protein
        )

            if(!this.sortedAsc)
            {
                this.cerealsCollectionCopy.reverse()
            }

        this.sortedAsc = !this.sortedAsc;
    }

    sortByname()
    {
        this.cerealsCollectionCopy = this.cerealsCollectionCopy.sort(
            (a,b) => a.name.localeCompare(b.name)
        )

            if(!this.sortedAsc)
            {
                this.cerealsCollectionCopy.reverse()
            }

        this.sortedAsc = !this.sortedAsc;
    }

    async searchByName(val)
    {
        await this.loadData();
        val = val.trim();
        if(val.length > 0)
        {
            val = val.toLowerCase()
            this.cerealsCollectionCopy = this.cerealsCollectionCopy.filter(cereal => cereal.name.toLowerCase().includes(val));
        } 
    }
}
export {Cereals}