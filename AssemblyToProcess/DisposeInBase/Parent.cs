using System;
using Janitor;

namespace DisposeInBase
{
    [Janitor]
    public class Parent:IDisposable
    {
        public void Dispose()
        {
            
        }
    }
}