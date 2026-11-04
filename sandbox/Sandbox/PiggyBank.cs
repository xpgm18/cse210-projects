class PiggyBank
{
    private float _balance;
    private bool _broken;
    public PiggyBank()
    {
        _balance = 0;
        _broken = false;
    }
    public void Deposit(float amount)
    {
        if (_broken)
        {
            Console.WriteLine("You cannot make a deposit: the bank is broken.");
        }
        else
        {
            _balance += amount;
        }
    }
    public float GetBalance()
    {
        return _broken ? 0 : _balance; // IF BROKEN RETURN 0 ELSE RETURN _BALANCE
    }
    public float Withdraw(float amount)
    {
        Console.WriteLine("ERROR - You cannot withdraw money from your piggy bank");
        return 0;
    }
    public float Break()
    {
        _broken = true;
        // _balance = 0;
        // return _balance;
        return GetBalance();        // equivalent to the above 2 lines
    }
}
