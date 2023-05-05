using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void NewMethod(string Filename)
        {
            object p = File.Create(Filename);

            private static void Main(string[] args)
            {
                string Filename = @"D:\Karen\Documents\tests\createdfile.text";

                try
                {
                    NewMethod(Filename);
                    Console.WriteLine("File successfully created!!");
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("File was not successfully created");
                }


            }

        }
    }
}
