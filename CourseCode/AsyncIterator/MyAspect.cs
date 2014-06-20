using System;
using PostSharp.Aspects;

namespace Pluralsight.PostSharpV3.Iterator
{
    [Serializable]
    public class MyAspect:OnMethodBoundaryAspect
    {
        #region PostSharp 3.x style, 2 new method OnYield, OnResume
        //public override void OnYield(MethodExecutionArgs args)
        //{
        //    Console.WriteLine("Yielding");
        //}

        //public override void OnResume(MethodExecutionArgs args)
        //{
        //    Console.WriteLine("Resuming");
        //}

        //public override void OnEntry(MethodExecutionArgs args)
        //{
        //    Console.WriteLine("Entering");
        //}

        //public override void OnExit(MethodExecutionArgs args)
        //{
        //    Console.WriteLine("Exiting");
        //}

        //public override void OnSuccess(MethodExecutionArgs args)
        //{
        //    Console.WriteLine("Success");
        //}
        #endregion


        #region  This style is PostSharp 2.x

        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Entering");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Exiting");
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine("Success");
        }

        #endregion
    }
}