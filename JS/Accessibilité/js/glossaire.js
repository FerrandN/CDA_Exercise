class Glossaire
{
    constructor(glossaire)
    {
        Object.assign(this,glossaire);
        this.ID;
    }

    getValues()
    {
        return Object.values(this);
    }

}
export {Glossaire}