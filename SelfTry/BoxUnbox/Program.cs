static class Program{
    static void Main(){
        int x = 5;
        object obj1 = x;
        int y = (int)obj1;
        Console.WriteLine(y);

        int a = 10;
        object obj2 = a;
        string str = ((int)obj2).ToString();
        Console.WriteLine(str);

        int c = 11;
        object obj3 = c;
        long d = (int)obj3;
        Console.WriteLine(d);

        float e = 12.2f;
        object obj6 = e;
        int i = (int)(float)obj6;
        Console.WriteLine(i);

        object obj4 = "Hello World";
        if (obj4 is string){
            string str4 = (string)obj4;
            Console.WriteLine(str4);
        }

        object obj5 = "haloo juga";
        if(obj5 is string str5){ 
            Console.WriteLine(str5);
        }

        object obj7 = "23";
        int j = obj7 as int? ?? 0;
        Console.WriteLine(j);

    }
}