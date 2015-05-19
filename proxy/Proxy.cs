namespace proxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject = new RealSubject();

        public override double Add(double x, double y)
        {
            return realSubject.Add(x, y);
        }

        public override double Sub(double x, double y)
        {
            return realSubject.Sub(x, y);
        }

        public override double Mul(double x, double y)
        {
            return realSubject.Mul(x, y);
        }

        public override double Div(double x, double y)
        {
            return realSubject.Div(x, y);
        }
    }
}
