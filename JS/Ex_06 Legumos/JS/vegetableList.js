import {Data} from "./data.js"
import { jsonConvertor } from "./jsonConvertor.js"

class VegetableList
{
    constructor()
    {
        this.vegetableList = [];
        this.vegetableListCopy = [];
        this.isSorted = true;
    }

    async loadData()
    {
        let temp = await Data.getDb("https://arfp.github.io/tp/web/frontend/grocery/legumos.json")
        this.vegetableList = temp;
        this.vegetableList = this.vegetableList.map(c=>new jsonConvertor(c));
        this.vegetableListCopy = Array.from(this.vegetableList);
    }
}
export {Sales}