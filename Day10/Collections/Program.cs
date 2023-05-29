namespace LearnCollections;

public class Program
{

    public static void Main(string[] args)
    {
        Dictionary<int, Employee> myDict = new Dictionary<int, Employee>();
        Employee boss = new Employee("big boss", 1);
        Employee karyawan = new Employee("staff", 5);
        Employee satpam = new Employee("security", 101);

        myDict.TryAdd(1, boss);
        myDict.TryAdd(101, satpam);
        myDict.TryAdd(5, karyawan);

        Console.WriteLine("Masukan Id anda");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        if (myDict.ContainsKey(id))
        {
            string value = (string)(object)myDict[id].role;
            switch (value)
            {
                case "editor":
                    Console.WriteLine("Anda sebagai editor");
                    string[] data = { "palu", "obeng", "bor" };
                    IndividualBox<string> arrayString = new IndividualBox<string>(data);
                    arrayString.Show();
                    arrayString.Replace(1,"gerinda");
                    arrayString.Show();

                    MixedContainer mixContainer = new MixedContainer();
                    mixContainer.AddToContainer("kertas");
                    mixContainer.AddToContainer("buku");
                    mixContainer.AddToContainer("laptop");
                    mixContainer.Show();
                    mixContainer.RemoveFromContainer(0);
                    mixContainer.Show();
                    break;
                case "viewer":
                    Console.WriteLine("Anda hanya bisa melihat data");


                    break;
                default:
                    Console.WriteLine("Role anda belum ditambahkan");
                    break;

            }
        }
        else Console.WriteLine("ID anda belum ditambahkan");

    }

}