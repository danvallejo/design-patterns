namespace bridge_ex_1_solution
{
    public abstract class Implementor
    {
        public abstract string GetGuide();
        public abstract string PlayVideo();
    }

    public class CableTelevisionImpl : Implementor
    {
        public override string GetGuide()
        {
            return "Cable TV - Guide";
        }

        public override string PlayVideo()
        {
            return "Play Cable TV - Video";
        }
    }

    public class LCDTelevisionImpl : Implementor
    {
        public override string GetGuide()
        {
            return "LCD TV - Guide";
        }

        public override string PlayVideo()
        {
            return "LCD Cable TV - Video";
        }
    }
}
