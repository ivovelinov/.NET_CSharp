using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyChangedInterfaceExample
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instance of the person class
        /// </summary>
        Person firstPerson;
        Person secondPerson;
        Person thirdPerson;
        

        public Form1()
        {

            InitializeComponent();

            /// <summary>
            /// subscribe to event and assign values to the Age propertie
            /// </summary>
            firstPerson = new Person();
            firstPerson.PropertyChanged += Person_PropertyChanged;
            firstPerson.Age= 1;

            secondPerson = new Person();
            secondPerson.PropertyChanged += AnotherPerson_PropertyChanged;
            secondPerson.Age= 2;

            thirdPerson = new Person();
            thirdPerson.PropertyChanged += ThirdPerson_PropertyChanged;
            thirdPerson.Age = 1;


        }

        /// <summary>
        /// Make the first person older event, button_1 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            firstPerson.Age ++;
        }

        /// <summary>
        /// Property changed event handler for the first person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Age")
            {
                textBox1.Text = firstPerson.Age.ToString();
            }
        }

        /// <summary>
        /// Property changed event handler for the second person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnotherPerson_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Age")
            {
                textBox2.Text = secondPerson.Age.ToString();
            }
        }

        /// <summary>
        /// Make the second person older event, button2 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            secondPerson.Age = secondPerson.Age + 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            thirdPerson.Age++;
        }

        private void ThirdPerson_PropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Age")
            {
                textBox3.Text = thirdPerson.Age.ToString();
            }
        }
    }
}
