namespace bridge_ex_1_solution
{
    public abstract class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public abstract string GetGuide();
        public abstract string PlayVideo();
    }

    public class MySmartTelevision : Abstraction
    {
        public override string GetGuide()
        {
            return implementor.GetGuide();
        }

        public override string PlayVideo()
        {
            return implementor.PlayVideo();
        }
    }

    public class LCDTelevision : Abstraction
    {
        public override string GetGuide()
        {
            return implementor.GetGuide();
        }

        public override string PlayVideo()
        {
            return implementor.PlayVideo();
        }
    }
}
