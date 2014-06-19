using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using PostSharp.Aspects;

namespace d2
{
    [Serializable]
    public class MethodTraceAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Debug.WriteLine(args.Method.Name + " started");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Debug.WriteLine(args.Method.Name + " finished");
        }
    }
}
