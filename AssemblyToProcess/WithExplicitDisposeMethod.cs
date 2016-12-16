using System;
using Janitor;

[Janitor]
public class WithExplicitDisposeMethod : IDisposable
{
    public Explicit Child = new Explicit();

    void IDisposable.Dispose()
    {
    }

    [Janitor]
    public class Explicit : IDisposable
    {
        void IDisposable.Dispose()
        {
        }
    }
}