using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace Aula32_Listas_WF
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adiconar elemenots no listbox e cria uma lista
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            //falta adicionar as coisas da list box 1 e 2 na 3

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox3.Items.Add(listBox1.Items[i].ToString());
                listBox1.Show();
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox3.Items.Add(listBox2.Items[i].ToString());
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            //txtbox 4 r 5
            //listBox1.Items.Remove
            

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(materialTextBox9.Text);
            materialTextBox9.Clear();
            //listBox3.Items.AddRange(listBox1);
        }

        private void materialTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(materialTextBox10.Text);
            materialTextBox10.Clear();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;

        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            listBox3.Sorted = true;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
           
                int i = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(i);
              
        }

        private void materialButton21_Click(object sender, EventArgs e)
        {
            int i = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(i);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
           label4.Text = $" Quantidade {listBox1.Text.Count()}";
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            label6.Text = $" Quantidade {listBox2.Text.Count()}";
        }

        private void materialButton19_Click(object sender, EventArgs e)
        {
            label9.Text = $" Quantidade {listBox3.Text.Count()}";
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(materialTextBox1.Text);
            
            listBox1.Items.Insert(int.Parse(materialTextBox2.Text), materialTextBox1.Text);
            materialTextBox1.Clear();
            materialTextBox2.Clear();

        }

        private void materialButton15_Click(object sender, EventArgs e)
        {
            
            //listBox2.Items.Add(materialTextBox7.Text);
            listBox2.Items.Insert(int.Parse(materialTextBox8.Text), materialTextBox7.Text);
            materialTextBox7.Clear();
            materialTextBox8.Clear();


        }

        private void materialTextBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            
            listBox3.Items.AddRange(listBox1.Items);
            listBox3.Items.AddRange(listBox2.Items);
            //não está limpando a lsita
            
            //foreach(char i in listBox3.Text)
            //{
            //    listBox3.Items.Remove(i);
            //}
            
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            
            int index = listBox1.Items.IndexOf(materialTextBox3.Text);

            //label5.Text = $"Achei na posição{listBox1.Items.IndexOf(materialTextBox3.Text)}";
            if (index >= 0)
            {
                label5.Text = $"achei na posição {index}";

            }
            else
            {
                label5.Text = "autor não encontrado";
            }
        }

        private void materialButton18_Click(object sender, EventArgs e)
        {
            int index = listBox2.Items.IndexOf(materialTextBox6.Text);
            if (index >= 0)
            {
                label10.Text = $"Achei na posição {index}";

            }
            else
            {
                label10.Text = "Autor não encontrado";
            }
        }

        private void materialTextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
