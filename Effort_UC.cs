﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nimble
{
    public partial class Effort_UC : UserControl
    {
        public static Effort_UC instance;
        public Effort_UC()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
