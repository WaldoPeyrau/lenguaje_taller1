using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Alumno> listAlumnos = new List<Alumno>();
            Alumno objAlumno = new Alumno();
            Console.WriteLine("\nINGRESAR 4 ALUMNOS ");
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("\nIngrese datos de alumno " + (i + 1));
                objAlumno = new Alumno();
                Console.WriteLine("\nRut ( ejem : 25434190-8 ) : ");
                string rut;
                rut = Console.ReadLine();
                int aux = 0; //variable de control
                while (!objAlumno.validarRut(rut) || aux == 1)
                {
                    Console.WriteLine("\nERROR!! : Rut inválido o ya ingresado. . .");
                    Console.WriteLine("\nRut ( ejem : 25434190-8 ) :");
                    rut = Console.ReadLine();
                    for (int j = 0; j < listAlumnos.Count; j++)
                    {
                        if (listAlumnos[j].Rut == rut)
                        {
                            aux = 1;
                        }
                    }
                }
                objAlumno.Rut = rut;
                Console.WriteLine("\nNombre : ");
                objAlumno.Nombre = Console.ReadLine();
                Console.WriteLine("\nApellido Paterno : ");
                objAlumno.ApellidoPat = Console.ReadLine();
                Console.WriteLine("\nApellido Materno : ");
                objAlumno.ApellidoMat= Console.ReadLine();
                Console.WriteLine("\nDireccion : ");
                objAlumno.Direccion = Console.ReadLine();

                Console.WriteLine("\nTeléfono : ");
                int tel;
                while(!int.TryParse(Console.ReadLine(),out tel))
				{
					Console.WriteLine("\nERROR !!! : Ingrese numero valido . . . ");
					Console.WriteLine("\nIngrese telfono : ");
				}
				while(!objAlumno.validarTel(tel))
				{
					Console.WriteLine("\nERROR !!! : Ingrese numero valido . . . ");
					Console.WriteLine("\nIngrese telfono : ");
				}
				
				objAlumno.Telefono = tel;
				
				
                listAlumnos.Add(objAlumno);
                Console.Clear();
            }
            int opc = objAlumno.menu();
            while (opc != 0)
            {
                if(opc == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\nIngrese rut para buscar ( ejem : 25434190-8 ) : ");
                    string rut;
                    rut = Console.ReadLine();
                    while (rut == "")
                    {
                        Console.WriteLine("\nIngrese rut para buscar ( ejem : 25434190-8 ) : ");
                        rut = Console.ReadLine();
                    }
                    int aux = 1;
                    for (int i = 0; i < listAlumnos.Count; i++)
                    {
                        if (listAlumnos[i].Rut == rut && aux == 1)
                        {
                            Console.WriteLine("\nAlumno encontrado !!");
                            Console.WriteLine("\nRut : " + listAlumnos[i].Rut);
                            Console.WriteLine("\nNombre : " + listAlumnos[i].Nombre);
                            Console.WriteLine("\nApellido Paterno : " + listAlumnos[i].ApellidoPat);
                            Console.WriteLine("\nApellido Materno : " + listAlumnos[i].ApellidoMat);
                            Console.WriteLine("\nDireccion : " + listAlumnos[i].Direccion);
                            Console.WriteLine("\nTelefono : " + listAlumnos[i].Telefono);
                            aux = 0;
                        }
                    }
                    if (aux == 1)
                    {
                        Console.WriteLine("\nAlumno no encontrado !!! ");
                    }
                    Console.WriteLine("\nPresione una tecla para continuar  . . .");
                    Console.ReadKey();
                    Console.Clear();
                    opc = objAlumno.menu();
                }
                else if(opc == 2)
                {
                    Console.Clear();
                    int tel = 0;
                    tel = objAlumno.validarTel(tel);
                    int aux = 1;
                    for (int i = 0; i < listAlumnos.Count; i++)
                    {
                        if (listAlumnos[i].Telefono == tel && aux == 1)
                        {
                            Console.WriteLine("\nAlumno encontrado !!");
                            Console.WriteLine("\nRut : " + listAlumnos[i].Rut);
                            Console.WriteLine("\nNombre : " + listAlumnos[i].Nombre);
                            Console.WriteLine("\nApellido Paterno : " + listAlumnos[i].ApellidoPat);
                            Console.WriteLine("\nApellido Materno : " + listAlumnos[i].ApellidoMat);
                            Console.WriteLine("\nDireccion : " + listAlumnos[i].Direccion);
                            Console.WriteLine("\nTelefono : " + listAlumnos[i].Telefono);
                            aux = 0;
                        }
                    }
                    if (aux == 1)
                    {
                        Console.WriteLine("\nAlumno no encontrado !!! ");
                    }
                    Console.WriteLine("\nPresione una tecla para continuar  . . .");
                    Console.ReadKey();
                    Console.Clear();
                    opc = objAlumno.menu();
                }
            }
        }
    }
}
