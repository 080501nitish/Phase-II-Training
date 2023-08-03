/*double num1, num2;
    int res;
num1 = Convert.ToDouble(Console.ReadLine());
num2 = Convert.ToDouble(Console.ReadLine());
res=(int)(num1+num2);
Console.WriteLine(res); */
/*int num, sum = 0;
num=Convert.ToInt32(Console.ReadLine());
int temp = num;

while (num > 0)
{
    int rem = num % 10;
    sum += (rem * rem * rem);
    num /= 10;
}
Console.WriteLine(((sum == temp) ? ("{0} this is a AN") : ("{0} not an armstrong")),temp); */

/*int num, sum = 0;
num = Convert.ToInt32(Console.ReadLine());
int temp = num;
for (int i=1; i<num; i++)
{

    if (num % i == 0)
    {
        sum += i;
    }
}
Console.WriteLine(((sum == temp) ? ("{0} this is a perfect number") : ("{0} this is not a perfect number")), temp); */


int start_num = 0, end_num = 0,count = 0;
start_num=Convert.ToInt32(Console.ReadLine());
end_num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The prime Numbers are");
for (int i = start_num; i <= end_num; i++)
{
    for(int j = 1; j <= start_num/2 ; j++)
    {
        if (i % j == 0)
        {
            count++;
        }
    }
    if (count == 1)
    {
        Console.WriteLine(i);
    }
    count = 0;
}
