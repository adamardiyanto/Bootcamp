class Cat {
	public Leg totalLeg;
	public void SetLeg(Leg x)
	{
		totalLeg = x;
	}
	public Leg GetTotalLeg()
	{
		return totalLeg;
	}
}
class Leg
{
	public int LegSize;
	public string nameLeg;
	public Nail totalNail;
	public Leg(Nail x)
	{
		totalNail = x;
		LegSize = 4;
		nameLeg = "kaki";
	}
}
class Nail 
{
	public int NailLength;
	public Nail()
	{
		NailLength = 5;
	}
}
static class Program
{
	static void Main()
	{
		Cat cotton = new Cat();
		Nail catNail = new Nail();
		Leg catLeg = new Leg(catNail);
		
		//cotton.SetLeg(catLeg);
		
		//cotton.totalLeg = catLeg;

		Leg legKosongan = cotton.GetTotalLeg();
		
		int x = legKosongan.LegSize;
		string y = legKosongan.nameLeg;
        //int a = legKosongan.totalNail;
		
		Console.WriteLine(y);
	}
}