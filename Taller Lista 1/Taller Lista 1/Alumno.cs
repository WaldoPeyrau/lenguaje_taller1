using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Lista_1
{
    public class Alumno
    {
        String _Rut;
        String _nombre;
        String _ApPaterno;
        String _ApMaterno;
        String _Direccion;
        int _Fono;

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

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string ApPaterno
        {
            get
            {
                return _ApPaterno;
            }

            set
            {
                _ApPaterno = value;
            }
        }

        public string ApMaterno
        {
            get
            {
                return _ApMaterno;
            }

            set
            {
                _ApMaterno = value;
            }
        }

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

        public int Fono
        {
            get
            {
                return _Fono;
            }

            set
            {
                _Fono = value;
            }
        }
    }
}
