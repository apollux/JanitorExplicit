using System.IO;
using Janitor;

[Janitor]
public class WhereJanitorAttributeAndNonEmptyDisposeMethod
{
    public MemoryStream DisposableField;

    public void Dispose()
    {
        DisposableField.Dispose();
    }
}
