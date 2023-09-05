import {Data} from "./data.js"
import { Glossaire } from "./glossaire.js"

class GlossaireList
{
    constructor()
    {
        this.glossaireCollection = [];
    }

    async getGlossaire()
    {
        let glossaireToAdd = await Data.getDB('./json/glossaire.json');
        let ID = 0;
        for(let glossaire of glossaireToAdd.glossaire)
        {
            glossaire.ID = ID++;
            this.glossaireCollection.push(new Glossaire(glossaire));
        }
    }
}
export{GlossaireList}