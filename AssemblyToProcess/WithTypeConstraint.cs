using System;
using Janitor;

[Janitor]
public class WithTypeConstraint<T> : IDisposable
    where T : IComparable
{
    public void Dispose() { }
    public void DisposeManaged() { }
    public void Bar() { }
}