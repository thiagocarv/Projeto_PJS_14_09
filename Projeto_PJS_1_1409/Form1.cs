﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PJS_1_1409
{
    
    public partial class Form1 : Form
    {
        Filmes filme = new Filmes();
        Dictionary<string, List<Filmes>> dic = new Dictionary<string, List<Filmes>>();

        public Form1()
        {
            InitializeComponent();
        }

        public void cadastrafilme(string nome, string genero, string data, string local)
        {
            filme.nome = nome;
            filme.genero = genero;
            filme.data = data;
            filme.local = local;
        }

        public void cadastralistview()
        {
            ListViewItem nome = new ListViewItem();

            nome.Text = tx1cad.Text;
            nome.Group = lv1cad.Groups[cb1cad.SelectedIndex];

            nome.SubItems.Add(dt1cad.Value.ToShortDateString().ToString());
            nome.SubItems.Add(rt1cad.Text);

            lv1cad.Items.Add(nome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           //código de cadastro no listview
                //lv1cad.Groups.Add(cb1cad.SelectedIndex.ToString(), cb1cad.SelectedItem.ToString());

            string nome = tx1cad.Text;
            string genero = cb1cad.SelectedItem.ToString();
            string data = dt1cad.Value.ToShortDateString().ToString();
            string local = rt1cad.Text;

            cadastrafilme(nome, genero, data, local);
            cadastralistview();    
            
                            
        }
    }
}
