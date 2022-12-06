//A terminal expression is one that does not contain any other expressions.
namespace Interpreter_Pattern
{
    public class TerminalExpression : IAbstractExpression
    {
        public void Interpret(Context context)
        {
            Debug.Log("Called Terminal.Interpret()");
        }
    }
}