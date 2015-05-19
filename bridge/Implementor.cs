namespace bridge
{
    public abstract class Implementor
    {
        public abstract string GetGuide();
        public abstract string PlayVideo();
    }

    public class CableTelevision : Implementor
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
}
