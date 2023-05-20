using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridAndAttributes
{
    public partial class Form1 : Form
    {
        private MyClass _myClass = new MyClass();

        public Form1()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = _myClass;
        }
    }
}
