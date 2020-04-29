namespace Prototype
{
    public abstract class Prototype
    {
        public Prototype(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public abstract Prototype Clone();
    }
}
