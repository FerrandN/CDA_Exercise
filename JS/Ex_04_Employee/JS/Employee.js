
class Employee
{
    /**
     * 
     * @param {Employee} employee 
     */
    constructor(employee)
    {
        Object.assign(this,employee);
    }

    getValues()
    {
        return Object.values(this);
    }

    getKeys()
    {
        return Object.keys(this);
    }

}


export {Employee};