using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RestauraDir
{
    public class Carpeta
    {
        DirectoryInfo _nombre;
        bool _restaurar;
        FileAttributes _atributos;
        string _ruta;

        public Carpeta(DirectoryInfo Nombre, bool Restaurar, FileAttributes Atributos, string Ruta)
        {
            this._nombre = Nombre;
            this._restaurar = Restaurar;
            this._atributos = Atributos;
            this._ruta = Ruta;
        }

        public DirectoryInfo Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public bool Restaurar
        {
            get { return this._restaurar; }
            set { this._restaurar = value; }
        }

        public FileAttributes Atributos
        {
            get { return this._atributos; }
            set { this._atributos = value; }
        }

        public string Ruta
        {
            get { return this._ruta; }
            set { this._ruta = value; }
        }

    }
}
