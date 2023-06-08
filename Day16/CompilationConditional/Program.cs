#define RELEASE
class Program {
	static void Main() {
		#if (DEBUG)
		Console.WriteLine("Mode debug diaktifkan.");
		#elif (RELEASE)
		Console.WriteLine("Production mode aktif");
		#endif

		Console.WriteLine("Program berjalan...");
	}
}