﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolmnurk
{
    public partial class Kolmnurk_vorms : Form
    {
        public Kolmnurk_vorms()
        {
            InitializeComponent();
        }

        private void Kolmnurk_vorms_Load(object sender, EventArgs e)
        {

        }

        private void Arvuta_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            Triangle t=new Triangle(a, b, c);
            lv.Items.Add("Külg A");
            lv.Items[0].SubItems.Add(t.OutputA());
            lv.Items.Add("Külg B");
            lv.Items[1].SubItems.Add(t.OutputB());
            lv.Items.Add("Külg C");
            lv.Items[2].SubItems.Add(t.OutputC());
            Triangle triangle = new Triangle(a, b, c);
            lv.Items.Add("Периметр");
            lv.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            lv.Items.Add("Площадь");
            lv.Items[4].SubItems.Add(Convert.ToString(triangle.PerimentrL()));
            lv.Items.Add("Cуществует");
            if (triangle.ExistTriangle) { lv.Items[5].SubItems.Add("Существует"); }
            else lv.Items[5].SubItems.Add("Не существует");


        }
    }
}
