namespace Calculator.Client.Model {
    public static class OperationExtension {
        public static string AsChar(this Operation operation) {
            switch (operation) {
                case Operation.Add:
                    return "+";
                case Operation.Divide:
                    return "/";
                case Operation.Multiply:
                    return "*";
                case Operation.Substract:
                    return "-";
                default:
                    return string.Empty;
            }
        }
    }
}