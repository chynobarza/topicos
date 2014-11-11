using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace VentanaReflexion
{
    public class Ventana : Form
    {
        public Ventana()
        {
            this.Size = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
          
            Button bPerro = new Button();
            bPerro.Click += new EventHandler(button1_Click);
            bPerro.SetBounds(150, 100, 100, 80);
            bPerro.Text = "Perro";
            bPerro.Name = "bAnimal";
            this.Controls.Add(bPerro);

            Button bDueño = new Button();
            bDueño.SetBounds(40, 100, 100, 80);
            bDueño.Text = "Dueño";
            bDueño.Name = "bDueño";
            bDueño.Click += new EventHandler(button1_Click);
            this.Controls.Add(bDueño);
          
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form();
            int i = 10;
            Console.Clear();
            form1.StartPosition = FormStartPosition.CenterScreen;
            Assembly Ensamblado = Assembly.LoadFile(@"C:\Users\JAVIER\Desktop\Veterinaria\Veterinaria\BibliotecaVeterinaria\BibliotecaVeterinaria\bin\Debug\BibliotecaVeterinaria.dll");
            Type[] types = Ensamblado.GetTypes();
            var estudiante = types.GetValue(1);
            List<string> tipos = new List<string>();
            Button B = (Button)sender;
            foreach (Type t in types)
            {
                MemberInfo[] po = t.GetMembers();
                foreach (MemberInfo p in po)
                {
                    if (p.ReflectedType.ToString().Equals("BibliotecaVeterinaria."+B.Text))
                    {
                        if (p.MemberType.ToString().Equals("Property"))
                        {
                            string words = p.ToString();

                            string[] split = words.Split(new Char[] { ' ' });
                            bool ok = false;

                            foreach (string s in split)
                            {


                                if (ok)
                                {
                                   
                                    Label l1 = new Label();
                                    l1.Location = new Point(10, i);
                                    l1.AutoSize = true;
                                    l1.Visible = true;
                                    l1.Text = s + ":";
                                    l1.Name = "L" + s;
                                    form1.Controls.Add(l1);

                                  

                                    TextBox t1 = new TextBox();
                                    t1.Location = new Point(75, i);
                                    t1.AutoSize = true;
                                    t1.Visible = true;
                                    t1.Name = "T" + s;
                                    form1.Controls.Add(t1);

                                    i = i + 25;
                                    if (s.Trim() != "")
                                        Console.WriteLine(s);
                                }
                                else
                                {
                                    tipos.Add(s);
                                }
                                ok = !ok;
                            }
                        } 
                    } 
                }
            } 

            Button bGuarda = new Button();
            bGuarda.Location = new Point(75, i + 20);
            bGuarda.Text = "Guardar";
            bGuarda.Name = "bGuardar";
            bGuarda.AutoSize = true;
            form1.Controls.Add(bGuarda);

           
            Button bCancelar = new Button();
            bCancelar.Location = new Point(155, i + 20);
            bCancelar.Text = "Cancelar";
            bCancelar.Name = "bCancelar";
            bCancelar.AutoSize = true;
            bCancelar.Click += new EventHandler(bCancelar_Click);
            form1.Controls.Add(bCancelar);
            form1.Text = "Formulario de " + B.Text;
            

            form1.AutoSize = true;
            form1.ShowDialog();
        }

        protected void bCancelar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Form f = (Form)b.Parent;
            f.Close();
            Console.Clear();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Ventana
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Ventana";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.ResumeLayout(false);

        }

        private void Ventana_Load(object sender, EventArgs e)
        {

        }
    }
}
