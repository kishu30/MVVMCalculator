using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVMCalculator.Models
{
    public class CalculatorLogicViewClass : INotifyPropertyChanged
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


        private int firstnumber;

        public int FirstNumber
        {
            get { return firstnumber; }
            set { firstnumber = value; OnPropertyChanged("FirstNumber"); }
        }

        private int secondnumber;

        public int SecondNumber
        {
            get { return secondnumber; }
            set { secondnumber = value; OnPropertyChanged("SecondNumber"); }
        }


        private int result;

        public int Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged("Result"); }
        }







    }


}

