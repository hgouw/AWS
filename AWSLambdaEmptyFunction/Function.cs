using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambdaEmptyFunction
{
    public class Function
    {
        public Result FunctionHandler(Request request)
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
