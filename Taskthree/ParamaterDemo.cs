public class ParameterDemo
{
    // Using ref parameter
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    // Using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Your Full Name";   
    }

    // Using params array
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}
