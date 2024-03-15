// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    int sumAvg = 0;
    foreach (var number in numbers)
    {
        sumAvg += number;
    }

    return (double) sumAvg / numbers.Length;
}

int[] numbers = {1,2,3,4};
Console.WriteLine(GetAverage(numbers));

static int getMax(int[] nums)
{
    int max = nums[0];
    foreach (var num in nums)
    {
        if (num > max)
            max = num;
    }

    return max;
}

Console.WriteLine(getMax(numbers));