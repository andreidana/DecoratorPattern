namespace DecoratorExample
{
    public class FieldPlayer: Footballer
    {
        public override int Run()
        {
            var footballerSpeed = base.Run();
            return footballerSpeed + 10;
        }
    }
}