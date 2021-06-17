using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class MathViewModel : INotifyPropertyChanged
    {
        private int _valueA;
        private int _valueB;
        private int _result;

        public int ValueA
        {
            get { return _valueA; }
            set
            {
                _valueA = value;
                OnPropertyChanged();
            }
        }

        public int ValueB
        {
            get { return _valueB; }
            set
            {
                _valueB = value;
                OnPropertyChanged();
            }
        }

        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = _valueA + _valueB;
                });
            }

        }

        public ICommand MultiplyCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = _valueA * _valueB;
                });
            }

        }

        public ICommand SubstCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = _valueA - _valueB;
                });
            }

        }

        public ICommand DivisCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = _valueA / _valueB;
                });
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
