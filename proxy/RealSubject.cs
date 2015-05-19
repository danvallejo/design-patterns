namespace proxy
{
    public class RealSubject : Subject
    {
        public override double Add(double x, double y) { return x + y; }
        public override double Sub(double x, double y) { return x - y; }
        public override double Mul(double x, double y) { return x * y; }
        public override double Div(double x, double y) { return x / y; }
    }
}
