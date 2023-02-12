namespace Weedwacker.GameServer.Data
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ResourceAttribute : Attribute
    {
        /* Name of the file that this Resource loads from */
        public readonly string Name;


        public ResourceAttribute(string names)
        {
            Name = names;
        }
    }
}
