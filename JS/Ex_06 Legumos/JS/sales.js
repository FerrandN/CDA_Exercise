import {Data} from "./data.js"
import { jsonConvertor } from "./jsonConvertor.js"

class Sales
{
    constructor()
    {
        this.salesList = [];
        this.salesListCopy = [];
        this.isSorted = true;
    }

    async loadData()
    {
        let temp = await Data.getDb("https://arfp.github.io/tp/web/frontend/grocery/legumos-sales.json")
        this.salesList = temp;
        this.salesList = this.salesList.map(c=>new jsonConvertor(c));
        this.salesListCopy = Array.from(this.salesList);
    }
}
export {Sales}