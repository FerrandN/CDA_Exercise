class TableGenerator
{
    constructor(cerealsTable)
    {
        this.cereals = cerealsTable;
        this.tBody = document.getElementById("cerealsTableBody");
        this.tHead = document.getElementById("cerealsTableHead");
        this.tFoot = document.getElementById("cerealsTableFooter");
        this.searchField = document.getElementById("site-search");
    }

    generateBody()
    {
        this.tBody.innerHTML="";
        for(let cereal of this.cereals.cerealsCollection)
        {
            let row = document.createElement('tr');
            this.tBody.appendChild(row);
            for(let data of cereal.getValue())
            {
                let cell = document.createElement('td');
                cell.textContent = data;
                if(data == "" && data != "0")
                {
                    this.createDeleteButton(row, cereal)
                }
                else
                {
                    if(cell.textContent == 'A')
                    {
                        cell.setAttribute('id','A');
                    }
                    else if(cell.textContent == 'B')
                    {
                        cell.setAttribute('id','B');
                    }
                    else if(cell.textContent == 'C')
                    {
                        cell.setAttribute('id','C');
                    }
                    else if(cell.textContent == 'D')
                    {
                        cell.setAttribute('id','D');
                    }
                    else if(cell.textContent == 'E')
                    {
                        cell.setAttribute('id','E');
                    }
                    row.appendChild(cell);
                }
            }
        }
    }

    generateHeader()
    {
        this.tHead.innerHTML="";
        let row = document.createElement('tr');
        this.tHead.appendChild(row);
        for(let cereal in this.cereals.cerealsCollection[0])
        {
            let cell = document.createElement('th');
            cell.textContent = cereal.toUpperCase();
            row.appendChild(cell);
        }
    }

    createDeleteButton(row, cereal)
    {
        let buttonDEL = document.createElement("button");
        let cell = document.createElement('td');
        buttonDEL.classList.add('btnDelete');
        buttonDEL.dataset.id = cereal.id;
        buttonDEL.addEventListener("click", (e)=>this.deleteCereal(e.target.dataset.id));
        cell.appendChild(buttonDEL);
        row.appendChild(cell);
    }

    deleteCereal(id)
    {
        document.getElementById("cerealsTableFooter").deleteRow(0);
        this.cereals.deleteCereal(id);
        this.generateBody();
        this.generateFooter();
    }

    generateFooter()
    {
        let row = document.createElement('tr');
        let count = 0;
        let totalCalories = 0;

        for(let cereal of this.cereals.cerealsCollection)
        {
            count++;
            totalCalories += cereal.calories;
        }

        for(let cereal in this.cereals.cerealsCollection[0])
        {
            let cell = document.createElement('td');

            if(cereal == "id")
            {
                cell.textContent = count; 
            }
            else if(cereal == "calories")
            {
                cell.textContent = (totalCalories/count).toFixed(2);
            }
            else
            {
                cell.textContent = "";
            }
            row.appendChild(cell);
        }
        row.className = 'rowTotal';
        this.tFoot.appendChild(row);
    }

}
export {TableGenerator}