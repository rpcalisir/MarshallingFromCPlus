using System.Runtime.InteropServices;


namespace ConsoleApp
{
    public static class Wrapper
    {
        [DllImport("NativeLibrary.dll")]
        public static extern void HelloWorld();

        //EntryPoint specifies which method to look for in C++ dll
        [DllImport("NativeLibrary.dll", EntryPoint = "Add")]
        public static extern int AddNumbers(int firstNumber, int secondNumber);

        [DllImport("NativeLibrary.dll")]
        public static extern bool IsLengthGreaterThanFive(string value);
    }
}
