using System.Runtime.InteropServices;

namespace Microsoft.Git.CredentialManager.Interop.Posix.Native
{
    public static class Stdlib
    {
        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern unsafe byte* realpath(byte* path, byte* resolved_path);
    }
}
