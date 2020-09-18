using System.Runtime.InteropServices;


namespace ConsoleApp
{
    public static class Wrapper
    {
        [DllImport("NativeLibrary.dll")]
        public static extern void HelloWorld();

        [DllImport("NativeLibrary.dll", EntryPoint = "Add")]
        public static extern int AddNumbers(int firstNumber, int secondNumber);
    }
}
