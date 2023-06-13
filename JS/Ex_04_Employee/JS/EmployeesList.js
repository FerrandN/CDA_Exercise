import {Employee} from "./Employee.js";

class EmployeesList
{
    constructor(_url)
    {
        /** @var {Employee[]} employeesCollection */
        this.employeesCollection=[];
        this.source=_url;
    }

    async getEmployee()
    {
        
        let resp = await fetch(this.source);
        let json = await resp.json();
        for(let person of json.data)
        {
            let year = new Date().getFullYear();
            person.employee_age = year - person.employee_age;

            person.employee_salary /= 12;
            person.employee_salary = (Math.round(person.employee_salary*100)/100);

            this.employeesCollection.push(new Employee(person))
        }
        
    }

    getEmployeeTotalSalary()
    {
        let sum = 0;
        this.employeesCollection.forEach(d=> sum+= d.employee_salary);
        return sum;
    }

    generateEmail(employeeName)
{
    let mail = "";
    const regex = / [A-z]*/;

    mail += employeeName[0] + '.' + employeeName.match(regex) + "@email.com";

    console.log(mail);

    return mail;
}

}

export {EmployeesList};