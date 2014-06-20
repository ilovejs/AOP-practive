using System.Linq;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;

namespace Pluralsight.PostSharpV3
{
    [Log("EntryExitLogging", 
        AttributeTargetElements = MulticastTargets.Method, 
        AttributeTargetMemberAttributes = MulticastAttributes.Public)]
    public class NameReverser
    {
        public string For(string name)
        {
            return new string(name.Reverse().ToArray());
        }
    }
}