using System;
using System.Collections.Generic;

namespace Pluralsight.PostSharpV3.Iterator
{
    public class CustomerRepository
    {
        [MyAspect]
        public IEnumerable<string> GetAllNames()
        {
            yield return "Sam's Autobody";
            yield return "Trucking Aggregates";
            yield return "Multi-thread Sewing";
        }
    }
}