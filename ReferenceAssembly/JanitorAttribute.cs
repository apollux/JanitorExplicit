using System;

namespace Janitor
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class JanitorAttribute : Attribute
    {
    }
}