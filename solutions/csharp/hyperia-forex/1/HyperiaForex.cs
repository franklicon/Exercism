public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return amountA.amount == amountB.amount;
    }

    public static bool operator !=(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return amountA.amount != amountB.amount;
    }

    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return amountA.amount > amountB.amount;
    }

    public static bool operator <(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return amountA.amount < amountB.amount;
    }

    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return new CurrencyAmount(amountA.amount + amountB.amount, amountA.currency);
    }

    public static decimal operator -(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return new CurrencyAmount(amountA.amount - amountB.amount, amountA.currency);
    }

    public static CurrencyAmount operator *(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return new CurrencyAmount(amountA.amount * amountB.amount, amountA.currency);
    }

    public static CurrencyAmount operator /(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if(amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }

        return new CurrencyAmount(amountA.amount * amountB.amount, amountA.currency);
    }

    // TODO: implement type conversion operators
    public static explicit operator double(CurrencyAmount amount)
    {
        return (double)amount.amount;
    }

    public static implicit operator decimal(CurrencyAmount amount)
    {
        return amount.amount;
    }
    
}
