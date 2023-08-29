using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangedInterfaceExample
{
  
    internal class Person : INotifyPropertyChanged
    {
        /// <summary>
        /// define class fileds
        /// </summary>
        public static int _personID;
        private int _age;
        private string _name;
        
        
        /// <summary>
        /// define properties
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    if (Age >= 0)
                    {
                        _age = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(nameof(Age));
                    }
                }
               
               OnPropertyChanged(nameof(Age));
            }
        }

        public string Name
        { 
            get { return _name; } 
            set { _name = value; }  
        }


        /// <summary>
        /// Event handler for Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)  
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
