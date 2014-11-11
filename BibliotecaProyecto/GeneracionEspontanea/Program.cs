using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaProyecto;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Drawing;

namespace BibliotecaProyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cargar DLL con Reflexión
            var DLL = Assembly.LoadFile(@"C:\BibliotecaProyecto.dll");
            
            //Explorar espacios de nombre con Reflexión
            Type[] types = DLL.GetExportedTypes();
            List<Type> myTypes = new List<Type>();
            foreach (Type t in types)
            {
               // if (t.Namespace == "BibliotecaProyecto")
                //{
                    myTypes.Add(t);
                //}
            }

            foreach (Type t in myTypes)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();
            
            //Explorar las clases

            MemberInfo[] myMemberInfo;
            PropertyInfo[] myPropertyInfo;
            foreach (Type type in DLL.GetExportedTypes())
            {
                myMemberInfo = type.GetMembers(BindingFlags.Public | BindingFlags.Instance);
                for (int i = 0; i < myMemberInfo.Length; i++)
                {
                    Console.WriteLine("EL METODO SE LLAMA " + myMemberInfo[i].Name + " Y ES DEL TIPO " + myMemberInfo[i].MemberType);

                }
                Console.ReadLine();
                myPropertyInfo = type.GetProperties();
                for (int i = 0; i < myPropertyInfo.Length; i++)
                {
                    Console.WriteLine("LA PROPIEDAD SE LLAMA " + myPropertyInfo[i].Name + "Y ES DEL TIPO " + myPropertyInfo[i].PropertyType);
                }
                Console.ReadLine();
                Console.WriteLine("EL NAMESPACE DE LA LIBRERÍA ES " + type.Namespace);
                Console.ReadLine();
                /*var c = Activator.CreateInstance(type);
                try
                {
                    type.InvokeMember("xxx", BindingFlags.InvokeMethod, null, c, new object[] { "Holii" });
                }
                catch
                {
                    Console.WriteLine("Ups, El método xxx no existe en esta clase");
                }*/
            }

            Console.ReadLine();
            
            //Generar ventana por clase

            
            //x.Size = new Size(900, 600);
            Principal_Seleccion y = new Principal_Seleccion();
            y.StartPosition = FormStartPosition.CenterScreen;
            //y.Size = new Size(450, 140);
            Application.Run(y);

            //Generar los controles de la ventana por propiedades de clase
            //Dar comportamiento a botón agregar (Repositorio - Agregar) - Invocar Método Agregar
            //Crear instancia y agregar


        }
    }
}
