
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

    /**
     * 
     * @returns 
     */
    getValues()
    {
        return Object.values(this);
    }

    /**
     * 
     * @returns 
     */
    getKeys()
    {
        return Object.keys(this);
    }

}


export {Employee};