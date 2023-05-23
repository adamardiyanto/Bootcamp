public class GenericOlshop{
    public private ProductFood internalProduct;
    public ProductFood DisplayProduct<T, T2, T3> (T a, T b, T c){
        if (a is string keyOne && b is int keyTwo){
            ProductFood myProductFood =new();
            myProductFood.name = keyOne;
            myProductFood.price = keyTwo;

            return myProductFood;
        }
        return null;
    }

    public void SetProduct<T>(T a){
        if(a is ProductFood myProductFood){
            internalProduct = myProductFood;
        }else{
            Console.WriteLine("invalid");
        }
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
        ProductFood myProductFood = GenericOlshop.DisplayProduct<>;
    }
}