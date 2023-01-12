//1
//int i = 1957;
//int sum = 0;
//while (i>0)
//{
//    sum += i % 10;
//    i /= 10;
//}
//if (sum%2==0)
//{
//    Console.WriteLine("ededin reqemleri cemi cutdur");
//}
//else
//{
//    Console.WriteLine("ededin reqemleri cemi tekdir");
//}

//2
//int i = 100;
//int sum = 0;
//while (i > 0)
//{
//    if (i % 13 == 0)
//    {
//        Console.WriteLine(i);
//        sum += i;
//        i--;
//    }
//    i--;
//}
//Console.WriteLine(sum);

//3
int i = 4216;
int k = 9;
while (i>0)
{
    if (k>i%10)
    {
        k = i % 10;
        i /= 10;
    }
    else
    {
        i /= 10;
    }
}
Console.WriteLine(k);