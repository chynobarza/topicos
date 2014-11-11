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
    public partial class Principal_Seleccion : Form
    {
        static int x = 100;
        static int x_lbl = 0;
        static int y = 3;
        public Principal_Seleccion()
        {
            InitializeComponent();
        }

        private void Principal_Seleccion_Load(object sender, EventArgs e)
        {
            var DLL = Assembly.LoadFile(@"C:\Users\Shaiduck\Documents\visual studio 2010\Projects\BibliotecaProyecto\BibliotecaProyecto\bin\Debug\BibliotecaProyecto.dll");
            int largo = 0;
            foreach (Type type in DLL.GetExportedTypes())
            {
                string[] palabras = type.ToString().Split('.');
                if (palabras.Length <= 2)
                {
                    Button btn = new Button();
                    Point ubica = new Point(x, 20 * y);
                    btn.Location = ubica;
                    btn.Text = palabras.Last();
                    btn.Size = new Size(100, 20);

                    btn.Click += new EventHandler(crearVentana_Clase);

                    this.Controls.Add(btn);
                    x = x + 150;
                    largo++;
                }
            }
            this.Text = "Constructor de Clases";
            this.Size = new Size(((largo *100)+200) + (50 * (largo - 1)), 140);
        }

        private void crearVentana_Clase(object sender, EventArgs e)
        {
            var nombre = sender as Button;
            Ventana x = new Ventana(nombre.Text);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            
        }
    }
}
