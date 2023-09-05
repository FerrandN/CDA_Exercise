class FillScrollBar
{
    constructor(glossaireListToAdd)
    {
        this.glossaireList = glossaireListToAdd;
        this.scrollBar = document.getElementById("glossaireBar");
    }

    fillScrollbar()
    {
        this.scrollBar.innerHTML="";
        for(let glossaire of this.glossaireList.glossaireCollection)
        {
            let title = document.createElement('option');
            title.textContent = glossaire.titre;
            this.scrollBar.appendChild(title);
        }
    }
}
export {FillScrollBar}