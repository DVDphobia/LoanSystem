using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] b = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int[] c = new int[20]; // Increased size to accommodate alternating values from both arrays
        private void button1_Click(object sender, EventArgs e)
        {
            // Initialize arrays a and b with sample values
            // Fill c alternately from a and b
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[index++] = a[i];
                c[index++] = b[i];
            }

            // Build result string
            listBox1.Items.Clear();

            // Add each number in c to the ListBox
            for (int i = 0; i < c.Length; i++)
            {
                listBox1.Items.Add(c[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Clear existing items
            for (int i = 0; i < a.Length; i++)
            {
                listBox1.Items.Add(a[i]);
            }

            // Add all elements from array b
            for (int i = 0; i < b.Length; i++)
            {
                listBox1.Items.Add(b[i]);
            }
        }


        int[,] aaa = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i =0; i < aaa.GetLength(0); i++)
            {
                for (int j = 0; j < aaa.GetLength(1); j++)
                {
                    listBox1.Items.Add(aaa[i, j]);
                }
            }
        }
    }
}