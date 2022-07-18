namespace Nullable
{
    public class Foo
    {
        public Foo(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public void Increment()
        {
            Number++;
        }

        public void Increment(int increment)
        {
            Number += increment;
        }
    }
}