using System;
using Janitor;

[Janitor]
public class WhereFieldIsIDisposableArray : IDisposable
{
    public IDisposable[] Field = new IDisposable[0];

    public void Dispose()
    {
    }

}