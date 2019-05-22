using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typeName = TypeNameValue.Text;
            Type T = Type.GetType(typeName);

            Properties.Items.Clear();
            Methods.Items.Clear();
            Constructors.Items.Clear();


            if (T != null) {
                PropertyInfo[] propertyies = T.GetProperties();
                foreach (PropertyInfo property in propertyies) {
                    Properties.Items.Add(property.GetType().Name + " " +property.Name);
                }


                MethodInfo[] methods = T.GetMethods();
                foreach (MethodInfo method in methods) {
                    Methods.Items.Add(method.ReturnType + " " + method.Name);
                }

                ConstructorInfo[] constructors = T.GetConstructors();
                foreach (ConstructorInfo constructor in constructors) {
                    Constructors.Items.Add(constructors.ToString());
                }



            }

        }
    }
}
