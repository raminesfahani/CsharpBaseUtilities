using System;

namespace Csharp.Utilities.Base.Tools.Annotations
{

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]  // Multiuse attribute.  
    public class EnvName : Attribute
    {
        public string Name { get; }
        public EnvName(string name)
        {
            Name = name;
        }
    }
}
