using System.Linq;

public partial class ModuleWeaver
{

    public void CleanReferences()
    {
        foreach (var typeDefinition in ModuleDefinition.GetTypes())
        {
            typeDefinition.CustomAttributes.RemoveJanitorAttribute();
        }

        var referenceToRemove = ModuleDefinition.AssemblyReferences.FirstOrDefault(x => x.Name == "Janitor");
        if (referenceToRemove == null)
        {
            LogInfo("\tNo reference to 'Janitor' found. References not modified.");
            return;
        }

        ModuleDefinition.AssemblyReferences.Remove(referenceToRemove);
        LogInfo("\tRemoving reference to 'Janitor'.");
    }
}