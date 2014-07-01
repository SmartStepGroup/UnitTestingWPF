#region Usings

using Calculator.Client.Model;

#endregion

namespace Calculator.Client.ViewModel {
    public class MainViewModel : MyViewModelBase {
        private Operation operation;
        private decimal result;

        public MainViewModel() {
            LeftOperand = 10;
            RightOperand = 5;
            Operation = Operation.Divide;
            CalculateCommand = new MyCommand(Calculate);
        }

        private void Calculate() {
            switch (Operation) {
                case Operation.Add:
                    Result = LeftOperand + RightOperand;
                    break;
                case Operation.Divide:
                    Result = LeftOperand / RightOperand;
                    break;
                case Operation.Multiply:
                    Result = LeftOperand * RightOperand;
                    break;
                case Operation.Substract:
                    Result = LeftOperand - RightOperand;
                    break;
            }
        }

        public int LeftOperand { get; set; }
        public int RightOperand { get; set; }

        public Operation Operation {
            get { return operation; }
            set {
                operation = value;
                OnPropertyChanged();
                OnPropertyChanged("OperationChar");
            }
        }

        public string OperationChar {
            get { return Operation.AsChar(); }
        }

        public decimal Result {
            get { return result; }
            set {
                result = value;
                OnPropertyChanged();
            }
        }

        public MyCommand CalculateCommand { get; private set; }
    }
}