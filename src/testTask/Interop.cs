using System;
using System.Runtime.InteropServices;

namespace testTask
{
    public class Interop
    {
        [DllImport( @"..\pluslib-x64.dll", CallingConvention=CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "sum")]
        private static extern int Sum64Internal(int a, int b);
        
        [DllImport( @"..\pluslib-x86", CallingConvention=CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "sum")]
        private static extern int Sum32Internal(int a, int b);
        
        public static int Sum(int a, int b)
        {
            return IntPtr.Size == 4 ? Sum32Internal(a, b) : Sum64Internal(a, b);
        }
    }
}