import { EmployeesList } from "./EmployeesList.js";

const employees = new EmployeesList("https://arfp.github.io/tp/web/frontend/employees/employees.json");

await employees.getEmployee();

const employeeArray = document.getElementById("tableEmployee");

const summOfEmployeeData = document.getElementById("totalSumm")


createTable();
//createFooter();

function createTable()
{
    
    for(let employee of employees.employeesCollection)
    {
        let row = document.createElement('tr');
        
        for(let data of employee.getValues())
        {
            let cell = document.createElement('td');
            
            cell.textContent = data;

            row.appendChild(cell);
        }
        employeeArray.appendChild(row);
    }
}

function createFooter()
{
    let row = document.createElement('tr');
    
}

function createHeader()
{
    let row = document.createElement('tr');
    for(let data in employees.employeesCollection)
    {
        let td = document.createElement('td');
        
    }
}