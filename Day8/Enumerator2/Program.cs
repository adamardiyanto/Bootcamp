using System.Collections;

class MyAntrian : IEnumerable
{
    private int[] data ={1,2,3,4,5,6,7,8,9,10};

    public IEnumerator GetEnumerator()
    {
        return new MyEnumerator(data);
    }

    private class MyEnumerator : IEnumerator
    {
        private int[] data;
        private int position = -1;

        public MyEnumerator(int[] data)
        {
            this.data = data;
        }

        public object Current
        {
            get { return this.data[position]; }
        }

        public bool MoveNext()
        {
            position++;
            return position < data.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyAntrian antrian = new MyAntrian();
        IEnumerator langkah = antrian.GetEnumerator();
        langkah.MoveNext(); 
        foreach (int antri in antrian )
        {   
            Console.WriteLine(langkah.Current);
            Console.WriteLine($"antrian didepan mu {antri}");
        }
        
    }
}

