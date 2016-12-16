using System;
using Janitor;

[Janitor]
public class WithProtectedDisposeManaged : IDisposable
{
    public void Dispose()
    {
    }

    protected virtual void DisposeManaged()
    {
        Console.WriteLine($"In {nameof(WithProtectedDisposeManaged)}.{nameof(DisposeManaged)}");
    }
}

[Janitor]
public class WithProtectedDisposeUnmanaged : IDisposable
{
    public void Dispose()
    {
    }

    protected virtual void DisposeUnmanaged()
    {
        Console.WriteLine($"In {nameof(WithProtectedDisposeUnmanaged)}.{nameof(DisposeUnmanaged)}");
    }
}

[Janitor]
public class WithProtectedDisposeManagedAndDisposeUnmanaged : IDisposable
{
    public void Dispose()
    {
    }

    protected virtual void DisposeManaged()
    {
        Console.WriteLine($"In {nameof(WithProtectedDisposeManagedAndDisposeUnmanaged)}.{nameof(DisposeManaged)}");
    }

    protected virtual void DisposeUnmanaged()
    {
        Console.WriteLine($"In {nameof(WithProtectedDisposeManagedAndDisposeUnmanaged)}.{nameof(DisposeUnmanaged)}");
    }
}

[Janitor]
public abstract class AbstractWithProtectedDisposeManaged : IDisposable
{
    public void Dispose()
    {
    }

    protected virtual void DisposeManaged()
    {
        Console.WriteLine($"In {nameof(AbstractWithProtectedDisposeManaged)}.{nameof(DisposeManaged)}");
    }
}

[Janitor]
public abstract class AbstractWithAbstractDisposeManaged : IDisposable
{
    public void Dispose()
    {
    }

    protected abstract void DisposeManaged();
}
