using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MVVMCalculator.Models;
using MVVMCalculator.Commands;
using System.Windows.Input;

namespace MVVMCalculator.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {

        #region inotifyproperty
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion


        private CalculatorLogicViewClass calculatorobject = new CalculatorLogicViewClass();

        public string FirstNumber
        {
            get { return calculatorobject.FirstNumber.ToString(); }

            set
            {
                calculatorobject.FirstNumber = Convert.ToInt32(value);
                OnPropertyChanged("FirstNumber");
            }

        }

        public string SecondNumber
        {

            get { return calculatorobject.SecondNumber.ToString(); }

            set
            {
                calculatorobject.SecondNumber = Convert.ToInt32(value);
                OnPropertyChanged("SecondNumber");
            }
        }


        public string Result
        {
            get { return calculatorobject.Result.ToString(); }

            set
            {
                calculatorobject.Result = Convert.ToInt32(value);
                OnPropertyChanged("Result");
            }
        }
        #region commands

        private ICommand addCommand;

        public ICommand AddCommand
        {
            get { return addCommand; }
            set { addCommand = value; }
        }



        #endregion

        public bool Canexecute(object obj)
        {
            //if( (Convert.ToInt32(FirstNumber) >0 && Convert.ToInt32(SecondNumber)>0 ) )
            //{
            //    return true;
            //}
            return true;

        }

        public void AddNumber(object obj)
        {
            Result = (Convert.ToInt32(FirstNumber) + Convert.ToInt32(SecondNumber)).ToString();
        }


        public void minus(object obj)
        {
            Result = (Convert.ToInt32(FirstNumber) - Convert.ToInt32(SecondNumber)).ToString();
        }

        public void multiply(object obj)
        {
            Result = (Convert.ToInt32(FirstNumber) * Convert.ToInt32(SecondNumber)).ToString();
        }

        public void divide(object obj)
        {
            Result = (Convert.ToInt32(FirstNumber) / Convert.ToInt32(SecondNumber)).ToString();
        }


        private ICommand subCommand;

        public ICommand SubCommand
        {
            get { return subCommand; }
            set { subCommand = value; }
        }

        private ICommand mulCommand;

        public ICommand MulCommand
        {
            get { return mulCommand; }
            set { mulCommand = value; }
        }

        private ICommand divCommand;

        public ICommand DivCommand
        {
            get { return divCommand; }
            set { divCommand = value; }
        }


        public UserViewModel()
        {
            addCommand = new RelayCommands(AddNumber, Canexecute);
            subCommand = new RelayCommands(minus, Canexecute);
            mulCommand = new RelayCommands(multiply, Canexecute);
            divCommand = new RelayCommands(divide, Canexecute);




        }



    }
}