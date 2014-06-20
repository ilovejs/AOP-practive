using System;
using PostSharp.Aspects;
using PostSharp.Reflection;

namespace Pluralsight.PostSharpV3
{
    [Serializable]
    public class StartsWithBeeAttribute: Attribute, ILocationValidationAspect<string>
    {
        public Exception ValidateValue(string value, 
            string locationName, LocationKind locationKind)
        {
            if (value.StartsWith("B")) return null;
            return new ApplicationException("Must start with B!");
        }
    }
}