
namespace WinAppDriver.Tests.Screenplay.Actions
{
    public static class Keyboard
    {
        public static TypeLetter TypeKeys(string expression) => new TypeLetter(expression);

        public static TypeOperation TypeOperator(string operation) => new TypeOperation(operation);

        public static TypeNumber TypeNumber(double number) => new TypeNumber(number);
    }
}
