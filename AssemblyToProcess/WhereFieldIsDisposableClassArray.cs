using System;
using Janitor;

[Janitor]
public class WhereFieldIsDisposableClassArray : IDisposable
{
    public Disposable[] Field = new Disposable[0];

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