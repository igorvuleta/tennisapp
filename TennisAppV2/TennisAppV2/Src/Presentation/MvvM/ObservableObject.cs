using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TennisAppV2.Src.Presentation.MvvM
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(
            ref T Property, T Value, [CallerMemberName] string PropertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(Property, Value))
            {
                return false;
            }

            Property = Value;
            this.OnPropertyChanged(PropertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string PropertyName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }
}
