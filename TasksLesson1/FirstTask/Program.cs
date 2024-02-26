using System.Runtime.Loader;

namespace FirstTask;
public class Program
{
    static void Main(string[] args)
    {

        string libraryPath = "C:\\Users\\Admin\\Desktop\\FirstHwTms\\OutputLibrary\\bin\\Debug\\net8.0\\OutputLibrary.dll";
        var assemblyLoadContext = new AssemblyLoadContext(null, true);

        try
        {
            var assembly = assemblyLoadContext.LoadFromAssemblyPath(libraryPath);

            var displayMessageType = assembly.GetType("OutputLibrary.DisplayMessage");

            object? displayMessageInstance = Activator.CreateInstance(displayMessageType);

            object? result = displayMessageType.GetMethod("DisplayText").Invoke(displayMessageInstance, null);

            if (result != null)
            {
                Console.WriteLine($"Result: {result}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unhandled error: {ex.Message}");
        }
        finally
        {
            assemblyLoadContext.Unload();
        }
    }
}