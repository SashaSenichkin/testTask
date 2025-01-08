using System.Runtime.InteropServices;

namespace testTask;

public unsafe partial class Interop
{
    [LibraryImport( @"..\pluslib-x64.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "sum")]
    private static partial int Sum64Internal(int a, int b);
        
    [LibraryImport( @"..\pluslib-x86", SetLastError = true, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "sum")]
    private static partial int Sum32Internal(int a, int b);
    
    public static int Sum(int a, int b)
    {
        return IntPtr.Size == 4 ? Sum32Internal(a, b) : Sum64Internal(a, b);
    }
}