using System;
using System.IO;
using Janitor;

[Janitor]
public class WithReadOnly:IDisposable
{
    readonly MemoryStream stream;

    public void Dispose()
    {
    }
    public WithReadOnly()
    {
        stream = new MemoryStream();
    }
    
}