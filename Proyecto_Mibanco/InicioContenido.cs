﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Mibanco
{
    public partial class InicioContenido : Form
    {
        public InicioContenido()
        {
            InitializeComponent();
            lblSaldo.Text = $"Saldo disponible: S/{Banco.Saldo}";
        }
    }
}