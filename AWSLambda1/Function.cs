using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda1;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(string input, ILambdaContext context)
    {
        Console.WriteLine("Test more 1");
        Console.WriteLine("Test more 2");
        Console.WriteLine("Test more 3");
        Console.WriteLine("Test more 4");
        Console.WriteLine("Test more 5");
        Console.WriteLine("Test more 6");
        Console.WriteLine("Test more 7");
        Console.WriteLine("Test more 8");
        Console.WriteLine("Test more 9");
        Console.WriteLine("Feature A");
        Console.WriteLine("Feature B");
        Console.WriteLine("Test");
        Console.WriteLine("Test2");
        Console.WriteLine("Test3");

        return input.ToUpper();
    }
}
