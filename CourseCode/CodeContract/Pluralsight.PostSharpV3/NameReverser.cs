using System.Linq;
using PostSharp.Patterns.Contracts;
/*
 *　hover mouse over parameter,
 *　add aspects
 */
namespace Pluralsight.PostSharpV3
{
    public class NameReverser
    {
        #region custom attribute
        //public string For([StartsWithBee] string name)
        //{
        //    return new string(name.Reverse().ToArray());
        //}
        #endregion

        #region existing attribute
        public string For([NotEmpty] string name)
        {
            return new string(name.Reverse().ToArray());
        }
        #endregion
    }
}