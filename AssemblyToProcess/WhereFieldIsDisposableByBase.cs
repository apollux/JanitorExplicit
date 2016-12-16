using System;
using DisposeInBase;
using Janitor;

[Janitor]
public class WhereFieldIsDisposableByBase:IDisposable
{
    public Child Child;

    public void Dispose()
    {
    }
    public WhereFieldIsDisposableByBase()
    {
        Child = new Child();
    }

    public void Method()
    {
    }
}