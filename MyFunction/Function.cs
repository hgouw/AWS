using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace MyFunction
{
    public class Function
    {     
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        //public string FunctionHandler(string input, ILambdaContext context)
        //{
        //    context.Logger.LogLine($"Calling function {context.FunctionName}");
        //    return input?.ToUpper();
        //}
        public string FunctionHandler(User user, ILambdaContext context)
        {
            context.Logger.LogLine($"Calling function {context.FunctionName}");
            return $"G'Day ... {user.FirstName} {user.LastName}";
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}