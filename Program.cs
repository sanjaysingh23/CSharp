//Create two static methd
// a.Public static int add(int a, int b) ==return sum of two number
//b. .  Public static int product(int a, int b)==return a * b;
//Declare delegate which can point to this method.
//Using reference of delegate call this method and print result

//Task
//Solve above program by making above method as instance method.


class DelegateDemo
{
    delegate int operation(int x, int y);
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int product(int a, int b)
    {
        return a * b;
    }
    public static void Main(String[] args)
    {
        operation oppObj = new operation(add);
        int addition = oppObj(10, 25);
        Console.WriteLine("Addition is {0} ", addition);
        oppObj = new operation(product);
        int result = oppObj(10, 4);
        Console.WriteLine("Product is {0}", result);

    }
}