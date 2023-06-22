class Cereal
{
    constructor(cereal)
    {
        Object.assign(this, cereal);
        this.NS = "";
        this.DEL ="";
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
        else if(this.rating >= 60 && this.rating < 80)
        {
            this.NS = "B";
        }
        else if(this.rating >= 40 && this.rating < 60)
        {
            this.NS = "C";
        }
        else if(this.rating >= 20 && this.rating < 80)
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