public static class SimpleCalculator
{
   private static readonly HashSet<string> AllowedOperations = ["+", "*", "/"];
    
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        var validationExceptionResult = ValidateOperation(operation);
        if (validationExceptionResult is not null)
        {
            throw validationExceptionResult;
        }
        
        var validationResult = ValidateOperation(operand1, operand2, operation!);
        return !string.IsNullOrEmpty(validationResult) ? validationResult :
            CalculateAux(operand1, operand2, operation!);
    }

    private static Exception? ValidateOperation(string? operation)
    {
        if (string.IsNullOrEmpty(operation))
        {
            return operation is null ? new ArgumentNullException(nameof(operation)) 
                : new ArgumentException("Empty operation", nameof(operation));
        }

        return !AllowedOperations.Contains(operation) 
            ? new ArgumentOutOfRangeException(nameof(operation)) : null;
    }

    private static string ValidateOperation(int operand1, int operand2, string operation)
    {
        if(operation == "/" && operand2 == 0)
        {
            return "Division by zero is not allowed.";
        }
        return string.Empty;
    }

    private static string CalculateAux(int operand1, int operand2, string operation) => operation switch
    {
        "+" => $"{operand1} + {operand2} = {operand1 + operand2}",
        "*" => $"{operand1} * {operand2} = {operand1 * operand2}",
        "/" => $"{operand1} / {operand2} = {operand1 / operand2}",
        _ => throw new ArgumentOutOfRangeException(nameof(operation))
    };
}
