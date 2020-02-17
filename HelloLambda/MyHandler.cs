using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;

//[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace HelloLambda
{
    public class MyHandler
    {
        [LambdaSerializer(typeof(JsonSerializer))]
        public Result HandleFunction(Request request)
        {
            return new Result
            {
                HelloWorld = request.Name
            };
        }
    }
    public class Request
    {
        public string Name { get; set; }
    }
    public class Result
    {
        public string HelloWorld { get; set; }
    }
}
