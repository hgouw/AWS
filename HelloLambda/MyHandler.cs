using System;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;
using System.Threading.Tasks;

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
