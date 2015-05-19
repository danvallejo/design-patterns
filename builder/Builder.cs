namespace builder
{
    public abstract class Builder
    {
        public abstract void BuildFrame();
        public abstract void BuildEngine();

        public abstract Product GetResult();
    }
}
