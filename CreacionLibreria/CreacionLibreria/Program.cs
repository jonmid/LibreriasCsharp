﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHelper fh = new FileHelper();
            var respuesta = fh.GetFileSystemObjects("./");

            foreach (var item in respuesta)
            {
                Console.WriteLine($"Nombre: {item.Name} - Tipo: {item.FileType}");
            }

            Console.ReadLine();
        }
    }
}
