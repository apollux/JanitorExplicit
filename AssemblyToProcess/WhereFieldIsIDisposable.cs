using System;
using Janitor;

[Janitor]
public class WhereFieldIsIDisposable : IDisposable
{
    public IDisposable Field = new Disposable();

    public void Dispose()
    {
    }

    [Janitor]
    public class Disposable : IDisposable
    {
        public void Dispose()
        {
        }
    }
}