using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Alumnos
{
    class Alumno
    {
        String _Rut;
        public string Rut
        {
            get
            {
                return _Rut;
            }

            set
            {
                _Rut = value;
            }
        }
        String _Nombre;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }
        String _ApellidoPat;
        public string ApellidoPat
        {
            get
            {
                return _ApellidoPat;
            }

            set
            {
                _ApellidoPat = value;
            }
        }
        String _ApellidoMat;
        public string ApellidoMat
        {
            get
            {
                return _ApellidoMat;
            }

            set
            {
                _ApellidoMat = value;
            }
        }
        String _Direccion;
        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }
        int _Telefono;
        public int Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public bool validarTel(int tel)
        {
            Console.WriteLine("\nIngrese telfono : ");
            if (tel == 0)
            { 
                while(!int.TryParse(Console.ReadLine(),out tel))
                {
                    Console.WriteLine("\nERROR !!! : Ingrese numero valido . . . ");
                    Console.WriteLine("\nIngrese telfono : ");
                }
            }
            return tel;
        }

        public int menu()
        {
            int opc;
            Console.WriteLine("\nMENU");
            Console.WriteLine("\n[ 1 ] Buscar por rut ");
            Console.WriteLine("\n[ 2 ] Buscar por telefono ");
            Console.WriteLine("\n[ 0 ] Salir ");
            Console.WriteLine("\nElegir :  ");
            while ((!int.TryParse(Console.ReadLine(), out opc)) || opc > 2 || opc < 0)
            {
                Console.WriteLine("\nERROR !! : Ingrese solo numeros o eliga una opcion valida . . . ");
                Console.WriteLine("\nElegir : ");
            }
            return opc;
        }

        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }


    }
}
