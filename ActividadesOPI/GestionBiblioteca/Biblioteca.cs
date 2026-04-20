using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Biblioteca2nd;

namespace Biblioteca2nd
{
    public class Biblioteca
    {
        private readonly List<Material> _misMateriales = new List<Material>();
        public void Agregar (Material nuevoMaterial)
        {
            _misMateriales.Add(nuevoMaterial);
            Console.WriteLine($"Agregado al inventario: {nuevoMaterial.Title}");
        }

        public void MostrarInventario()
        {
            Console.WriteLine("^^Inventario Actual^^");
            foreach (var item in _misMateriales)
            {
                Console.WriteLine($"-{item.Title} (Disponible: {item.IsAvailable})");
            }
        }
    }
}

