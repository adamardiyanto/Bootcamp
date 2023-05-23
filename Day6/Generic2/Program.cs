static public class GenericOlshop{
    public static ProductFood internalProduct;
    public static ProductFood? DisplayProduct<T, T2, T3> (T a, T2 b, T3 c){
        if (a is string keyOne && b is int keyTwo){
            ProductFood myProductFood =new();
            myProductFood.Name = keyOne;
            myProductFood.Price = keyTwo;

            return myProductFood;
        }
        return null;
    }

    public static void SetProduct<T>(T a){
        if(a is ProductFood myProductFood){
            internalProduct = myProductFood;
        }else{
            Console.WriteLine("invalid");
        }
    }

    public static ProductFood? ProductEditor<T, T2> (T a, T2 b){
        if(a is string keyOne &&b is int keyTwo){
            internalProduct.Name = keyOne;
            internalProduct.Price = keyTwo;
            return internalProduct;
        }
        return null;
    }


}

public class ProductFood {
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

}

static class Program{
    static void Main(string[] args){
        ProductFood myProductFood = GenericOlshop.DisplayProduct<string, int, int>("Burger", 5, 34);
        Console.WriteLine(myProductFood.Name);
        Console.WriteLine(myProductFood.Price);

        GenericOlshop.SetProduct<ProductFood>(myProductFood);
        myProductFood = GenericOlshop.ProductEditor<string, int>("Pizaa",1000);
        Console.WriteLine(myProductFood.Name);
        Console.WriteLine(myProductFood.Price);
    }
}