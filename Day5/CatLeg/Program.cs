class Cat{
    public Leg totalLeg;

    public void SetLeg (Leg x){
        totalLeg = x;
    }
}

class Leg{
    public int LegSize;
    public Leg (int x){
        LegSize= x;
    }

}

class Program{
    public static void Main(String[] args){
        Cat milo = new Cat();
        Leg catLeg = new Leg(4);
        milo.SetLeg(catLeg);
        Console.WriteLine(milo.totalLeg.LegSize);
    
    }
}