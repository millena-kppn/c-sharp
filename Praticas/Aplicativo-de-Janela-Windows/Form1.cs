﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Aplicativo_de_Janela_Windows
{
    public partial class Aplicacao : Form
    {
        public Aplicacao()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            string nome = CaixadeTexto.Text;
            CaixadeTexto.Text = $"Bem vindo(a) {nome}!";    

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = "Nome excluido!";
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
