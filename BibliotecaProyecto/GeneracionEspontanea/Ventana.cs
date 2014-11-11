using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Reflection.Emit;

namespace BibliotecaProyecto
{
    public partial class Ventana : Form
    {
        public string nombre_espacio;

        public Ventana(String x)
        {
            this.nombre_espacio = x;
            InitializeComponent();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            int x = 200;
            int x_lbl = 100;
            int y = 1;
            int elementos = 1;

            var DLL = Assembly.LoadFile(@"C:\BibliotecaProyecto.dll");
            var enviado = sender as Button;
            PropertyInfo[] myPropertyInfo;
            foreach (Type type in DLL.GetExportedTypes())
            {
                if (type.ToString() == type.Namespace+"."+nombre_espacio)
                {
                    myPropertyInfo = type.GetProperties();
                    for (int i = 0; i < myPropertyInfo.Length; i++)
                    {
                        System.Windows.Forms.Label nombre = new System.Windows.Forms.Label();
                        nombre.Text = myPropertyInfo[i].Name;
                        Point punto_nombre = new Point(x_lbl, 30 * y);
                        nombre.Location = punto_nombre;
                        nombre.Size = new Size(100, 20);
                        this.Controls.Add(nombre);

                        TextBox tb = new TextBox();
                        tb.Text = nombre_espacio;
                        Point p = new Point(x, 30 * y);
                        tb.Location = p;
                        this.Controls.Add(tb);
                        y++;
                        string[] palabras = type.ToString().Split('.');
                        this.Text = palabras.Last();
                    }
                    x_lbl = x_lbl + 300;
                    x = x + 300;
                }
            }
            Button agregar = new Button();
            agregar.Text = "Agregar";
            agregar.Location = new Point(x_lbl-300, 30 * y);
            this.Controls.Add(agregar);
            y++;
            y = y + 2;
            this.Size = new Size(x -100, 30*y);
        }
    }
}
