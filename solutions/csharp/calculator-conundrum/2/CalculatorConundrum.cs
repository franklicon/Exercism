public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        return operation switch
        {
            "*" => $"{operand1} * {operand2} = {operand1 * operand2}",
            "+" => $"{operand1} + {operand2} = {operand1 + operand2}",
            "/" => operand2 != 0 ? $"{operand1} / {operand2} = {operand1 / operand2}" : "Division by zero is not allowed.",
            "" => throw new ArgumentException("Operation cannot be empty.", nameof(operation)),
            null => throw new ArgumentNullException(nameof(operation)),
            _ => throw new ArgumentOutOfRangeException(nameof(operation)),
        };
    }
}
