using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Single Responsibility Principle Example Code:

            //What is Single Responsibility Principle accoring to "whatis.techtarget.com/definition/Single-Responsibility-Principle-SRP" wepbage:
            //The Single Responsibility Principle(SRP) is the concept that any single object in object-oriented programing(OOP) should be made for one specific function.
            //SRP is part of SOLID programming principles put forth by Robert Martin.Traditionally, code that is in keeping with SRP  has a single function per class.

            //A class should have one, and only one, reason to change.
            //-Robert C.Martin




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
