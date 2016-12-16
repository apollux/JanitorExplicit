using System;
using Janitor;

[Janitor]
public class WithOverriddenDisposeManaged : WithProtectedDisposeManaged
{
    protected override void DisposeManaged()
    {
        Console.WriteLine($"In {nameof(WithOverriddenDisposeManaged)}.{nameof(DisposeManaged)}");
        base.DisposeManaged();
    }
}

[Janitor]
public class WithOverriddenDisposeUnmanaged : WithProtectedDisposeUnmanaged
{
    protected override void DisposeUnmanaged()
    {
        Console.WriteLine($"In {nameof(WithOverriddenDisposeUnmanaged)}.{nameof(DisposeUnmanaged)}");
        base.DisposeUnmanaged();
    }
}

[Janitor]
public class WithOverriddenDisposeManagedAndDisposeUnmanaged : WithProtectedDisposeManagedAndDisposeUnmanaged
{
    protected override void DisposeManaged()
    {
        Console.WriteLine($"In {nameof(WithOverriddenDisposeManagedAndDisposeUnmanaged)}.{nameof(DisposeManaged)}");
        base.DisposeManaged();
    }

    protected override void DisposeUnmanaged()
    {
        Console.WriteLine($"In {nameof(WithOverriddenDisposeManagedAndDisposeUnmanaged)}.{nameof(DisposeUnmanaged)}");
        base.DisposeUnmanaged();
    }
}

[Janitor]
public class WithAbstractBaseClass : AbstractWithProtectedDisposeManaged
{
    protected override void DisposeManaged()
    {
        Console.WriteLine($"In {nameof(WithAbstractBaseClass)}.{nameof(DisposeManaged)}");
        base.DisposeManaged();
    }
}

[Janitor]
public class WithAbstractDisposeManaged : AbstractWithAbstractDisposeManaged
{
    protected override void DisposeManaged()
    {
        Console.WriteLine($"In {nameof(WithAbstractDisposeManaged)}.{nameof(DisposeManaged)}");
    }
}
