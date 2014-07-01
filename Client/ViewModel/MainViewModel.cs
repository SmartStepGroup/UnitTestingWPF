#region Usings

using Calculator.Client.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

#endregion

namespace Calculator.Client.ViewModel {
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase {
        private Operation operation;
        private decimal result;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel() {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            LeftOperand = 10;
            RightOperand = 5;
            Operation = Operation.Divide;
            CalculateCommand = new RelayCommand(Calculate);
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
                RaisePropertyChanged(() => Operation);
                RaisePropertyChanged(() => OperationChar);
            }
        }

        public string OperationChar {
            get { return Operation.AsChar(); }
        }

        public decimal Result {
            get { return result; }
            set {
                result = value;
                RaisePropertyChanged(() => Result);
            }
        }

        public RelayCommand CalculateCommand { get; private set; }
    }
}