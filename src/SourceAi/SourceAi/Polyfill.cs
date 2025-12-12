namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit {}
    
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InterceptsLocationAttribute : Attribute
    {
        public InterceptsLocationAttribute(string filePath, int line, int character)
        {
            FilePath = filePath;
            Line = line;
            Character = character;
        }

        public string FilePath { get; }
        public int Line { get; }
        public int Character { get; }
    }
}
