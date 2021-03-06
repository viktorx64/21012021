﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManagement.Business.Concrete;

namespace ProductManagement.Windows.UI
{
    public partial class Form1 : Form
    {
        private LocalStorage _repository;
        private ShoppingCart _cart;
        public Form1()
        {
            InitializeComponent();

            _repository = new LocalStorage();
            _cart = new ShoppingCart();

            //Populera listan med alla produkter

            foreach (var item in _repository.GetProducts())
            {
                listBox1.Items.Add(item);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //Lägg den markerade produkten i ShoppingCart
            //MessageBox.Show("Test: " + listBox1.SelectedItem.ToString());
            Product p = listBox1.SelectedItem as Product;

            _cart.AddProduct(p);

            listBox2.Items.Clear();
            foreach (var item in _cart.GetProducts())
            {
                listBox2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lägg till info från forulär och skicka till produkter
            String Name = textBox1.Text;
            int Price = int.Parse(textBox2.Text);
            MessageBox.Show($"you have inserted: {Name}  (£{Price})");
            _repository.AddProd(Name, Price);
            textBox1.Text = "";
            textBox2.Text = "";

            listBox1.Items.Clear();
            foreach (var item in _repository.GetProducts())
            {
                listBox1.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
