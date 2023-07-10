class TableGenerator
{
    constructor(_listCereal)
    {
        this.listCereal = _listCereal;
        this.tBody = document.getElementById("cerealTableBody");
        this.tHead = document.getElementById("cerealTableHead");
    }

    generateTable()
    {
        this.tBody.innerHTML="";
        for(let cereal of this.listCereal.cerealsCollectionCopy)
        {
            let tr = this.generateRow(cereal);
            this.tBody.appendChild(tr);
        }
    }

    generateRow(cereal)
    {
        let tr = document.createElement("tr");
        for (let val of cereal.getValues())
        {
            let cellTemp = this.generateCell(val);
            tr.appendChild(cellTemp);
        }
        return tr;
    }

    generateCell(val)
    {
        let td = document.createElement("td");
        td.textContent=val;
        return td;
    }

    generateHeader()
    {
        this.tHead.innerHTML ="";
        let tr = document.createElement("tr");
        for(let val in this.listCereal.cerealsCollectionCopy[0])
        {
            let cell = document.createElement("th");
            cell.textContent = val;
            cell.setAttribute("id",val)
            tr.appendChild(cell);
        }
        this.tHead.appendChild(tr);
    }

}
export{TableGenerator}