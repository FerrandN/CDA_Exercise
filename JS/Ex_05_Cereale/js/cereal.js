class Cereal
{
    constructor(cereal)
    {
        Object.assign(this, cereal);
        this.NS = "";
        this.DEL = "";
        this.getNS();
    }

    getValue()
    {
        return Object.values(this);
    }

    getKeys()
    {
        return Object.keys(this);
    }

    getNS()
    {
        if(this.rating >= 80)
        {
            this.NS = "A";
        }
        else if(this.rating >= 70 && this.rating < 80)
        {
            this.NS = "B";
        }
        else if(this.rating >= 55 && this.rating < 70)
        {
            this.NS = "C";
        }
        else if(this.rating >= 35 && this.rating < 55)
        {
            this.NS = "D";
        }
        else
        {
            this.NS = "E";
        }
    }
}
export {Cereal}