namespace LearnCollections;
public class Employee 
{
    public string name { get; private set; }
    public int id { get; private set; }

    public string role { get; private set;}

    public Employee (string name, int id)
    {
        this.name = name;
        this.id = id;
        role = (id > 100)? "viewer" : "editor";
    }
}