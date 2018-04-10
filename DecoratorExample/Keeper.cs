namespace DecoratorExample
{
    public class Keeper: Footballer
    {
        public override int Run()
        {
            var footballerSpeed = base.Run();
            return footballerSpeed - 1;
        }
    }
}