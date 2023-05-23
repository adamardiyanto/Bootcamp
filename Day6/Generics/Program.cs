public class ToolBox<T> {
    private T _tool;

    public void AddTool(T tool) {
        _tool = tool;
    }

    public T GetTool(){
        return _tool;
    }
}

static class Program{
    static void Main(string[] args){
        ToolBox<string> drillBox = new();
        drillBox.AddTool("drill");
        Console.WriteLine(drillBox.GetTool());

        ToolBox<string> hammerBox = new();
        hammerBox.AddTool("hammer");
        Console.WriteLine(hammerBox.GetTool());

        ToolBox<int> totalBox = new();
        totalBox.AddTool(9);
        Console.WriteLine(totalBox.GetTool());
        

    }
}