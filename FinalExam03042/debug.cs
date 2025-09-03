public class Money : IEquatable<Money>
{

    public int Amount;
    public string code;
    public Money(int m, string s)
    {
        this.Amount = m;
        this.code = s;
    }

    public bool Equals(Money other)
    {
        if (other == null)
        {
            return false;
        }

        if (this.Amount == other.Amount)
        {
            return true;
        }
        return false;
        
        
    

    }
    public static Money operator +(Money other, Money x)
    {
        Money sum = new Money(other.Amount + x.Amount, "USD");

        return sum;
    }
    public static bool operator ==(Money other, Money x)
    {
        if (other != null && x != null)
            return x.Amount == other.Amount;
        return false; 
    }
    public static bool operator !=(Money other, Money x)
    {
        if (other != null)
            return x.Amount != other.Amount;
        return false;

        
    }
}