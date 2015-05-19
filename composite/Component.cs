namespace composite
{
    public abstract class Component
    {
        public string Name { get; set; }

        protected Component(string name)
        {
            Name = name;
        }

        public abstract void Draw();
    }
}
