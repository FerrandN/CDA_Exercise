import { Employee } from "./Employee.js";
import { EmployeesList } from "./EmployeesList.js";

const employees = new EmployeesList("https://arfp.github.io/tp/web/frontend/employees/employees.json");

await employees.getEmployee();

let employeeArray = document.getElementById("tableEmployee");

const summOfEmployeeData = document.getElementById("totalSumm")

const headOfEmployeeTable = document.getElementById("tableHead")

createHeader();
createTable();
createFooter();

findRow();

function createTable()
{

    for(let employee of employees.employeesCollection)
    {
        let row = document.createElement('tr');

        employee.mail = employees.generateEmail(employee.employee_name);
        let collection = getValueToShow(employee);
        
        for(let i = 0; i < collection.length; i++)
        {
            let employeeData = collection;

            let data = employeeData[i];
            
            let cell = document.createElement('td');
            
            cell.textContent = data;
            
            row.appendChild(cell);

        }

        let cellButton = document.createElement('td');

        cellButton.appendChild(generateButtonDuplicate());
        cellButton.appendChild(generateButtonDelete());

        row.appendChild(cellButton);

        employeeArray.appendChild(row);
    }
}

/**
 * 
 * @param {Employee} data 
 */
function getKeysToShow(data){
    let keys = data.getKeys();
    keys.forEach((d,i)=> {
        if (d == "profile_image")
        {
            keys.splice(i,1);
        }
    });
    return keys;
}

/**
 * 
 * @param {Employee} data 
 */
function getValueToShow(data)
{
    let keys = getKeysToShow(data);
    let value = [];
    keys.forEach(d => {
        value.push(data[d]);
    });
    return value;
}

function createFooter()
{
    summOfEmployeeData.appendChild(createFooterLine());
}

function createFooterLine()
{
    let tr = document.createElement('tr');
    let td = document.createElement('td');
    td.innerHTML = employees.employeesCollection.length;
    td.colSpan = 2;
    let tdInfo = document.createElement('td');
    tdInfo.innerText = Math.round(employees.getEmployeeTotalSalary()*100)/100;
    tdInfo.colSpan = 2;
    tr.appendChild(td);
    tr.appendChild(tdInfo);
    return tr;
}

function createHeader()
{
    let person = employees.getFirst();
    let row = document.createElement('tr');

    let cellAction = document.createElement('th');
    let cellMail = document.createElement('th');

    cellAction.textContent = "Action";
    cellMail.textContent = "Mail";

    let collection = getKeysToShow(person);
    
    for(let i = 0; i < collection.length; i++)
    {
        let data = collection[i];
        let cell = document.createElement('th');
        cell.textContent = data;
        
        if(collection[i] == "employee_salary")
        {
            let sortButton = generateButtonSort();
            cell.appendChild(sortButton);
        }

        row.appendChild(cell);
    }
    row.appendChild(cellMail)
    row.appendChild(cellAction)

    headOfEmployeeTable.appendChild(row);
}

function generateButtonDuplicate()
{
   let button = document.createElement('button');
   button.setAttribute("id","Duplicate");
   button.innerText ="Duplicate";
   button.addEventListener("click",duplicateRow())
   return button;
}

function generateButtonDelete()
{
   let button = document.createElement('button');
   button.setAttribute("id","Delete");
   button.innerText ="Delete";
   button.addEventListener("click",deleteRow())
   return button;
}

function generateButtonSort()
{
    let button = document.createElement('button');
    button.setAttribute("id","Sort");
    button.style.height = "30px";
    button.style.width = "30px";
    button.addEventListener("click",sortArrayBySalary)

    return button;
}

function sortArrayBySalary()
{
    
    
}

function deleteRow()
{
    
}

function duplicateRow(row)
{
    let rowToDuplicate = document.createElement('tr');
    rowToDuplicate = row;
    //employeeArray.appendChild(row);
}

function findRow()
{
    let table = document.querySelector("#tableEmployee");
    for(let row in table.rows)
    {
        for(let id in row)
        {
            console.log(id);
        }
    }
}

