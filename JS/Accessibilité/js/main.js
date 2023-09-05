import { GlossaireList } from "./glossaireList.js";
import {FillScrollBar} from "./fillScrollBar.js"

let glossaireList = new GlossaireList();
await glossaireList.getGlossaire();

let glossaireScrollBar = new FillScrollBar(glossaireList);
glossaireScrollBar.fillScrollbar();

let textArea = document.getElementById("glossaireBody")

let selectBar = document.getElementById("glossaireBar");
selectBar.addEventListener("change", (event) =>{
    textArea.innerHTML = glossaireList.glossaireCollection[event.target.selectedIndex].corps;
});

textArea.innerHTML = glossaireList.glossaireCollection[0].corps;
