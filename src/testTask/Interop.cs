using System.Runtime.InteropServices;

namespace testTask
{
    public class Interop
    {
        [DllImport("PLUSLIB_API-x64", CallingConvention=CallingConvention.StdCall)]
        public static extern long Sum(long a, long b);

    }
}