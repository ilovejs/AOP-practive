using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using PostSharp.Aspects;

namespace d2
{
    [Serializable]
    public class DatabaseExceptionWrapper : OnExceptionAspect
    {
        //public ExceptionType ExceptionType { get; set; }

        public override void OnException(MethodExecutionArgs args)
        {
            string msg = string.Format("{0} had an error @ {1}: {2}\n{3}",
                                            args.Method.Name, DateTime.Now,
                                            args.Exception.Message, 
                                            args.Exception.StackTrace);

            Trace.WriteLine(msg);

            throw new Exception("Postsharp: There was a problem");
        }

        /*
         * Returning the type you wish to handle
        *  Build the catch clause to only handle InvalidOperationException types. 
        */
        public override Type GetExceptionType(System.Reflection.MethodBase targetMethod)
        {
            return typeof(InvalidOperationException);
        }
    }
}
