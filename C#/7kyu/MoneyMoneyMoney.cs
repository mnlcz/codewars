namespace _7kyu;
public static class MoneyMoneyMoney
{
    public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
    {
        var calculate = (ref double actual) => actual = actual + (actual * interest) - (actual * interest * tax);
        var years = 0;
        while (principal < desiredPrincipal)
        {
            calculate(ref principal);
            years++;
        }
        return years;
    }
}
