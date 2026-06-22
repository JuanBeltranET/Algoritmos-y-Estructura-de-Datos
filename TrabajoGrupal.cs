using System;
using System.Collections.Generic;

namespace GestorPokemon
{
    // Estructura requerida
    struct Pokemon
    {
        public string nombre;
        public int nivel;
        public double poderDeCombate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokedex = new List<Pokemon>();
            bool ejecutar = true;

            while (ejecutar)
            {
                Console.WriteLine("\n--- MENÚ POKÉDEX ---");
                Console.WriteLine("1. Registrar nuevo Pokémon");
                Console.WriteLine("2. Mostrar todos los Pokémon");
                Console.WriteLine("3. Calcular promedio de PC");
                Console.WriteLine("4. Buscar Pokémon por nombre");
                Console.WriteLine("5. Mostrar Pokémon que superan el promedio");
                Console.WriteLine("6. Mostrar Pokémon con PC máximo y mínimo");
                Console.WriteLine("7. Liberar Pokémon (Eliminar)");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // TODO: Implementar registro con try-catch
                        try
                        {
                            Pokemon nuevoPokemon;
                            Console.Write("Nombre del Pokémon: ");
                            nuevoPokemon.nombre = Console.ReadLine();
                            Console.Write("Nivel: ");
                            nuevoPokemon.nivel = int.Parse(Console.ReadLine());
                            Console.Write("Poder de Combate: ");
                            nuevoPokemon.poderDeCombate = double.Parse(Console.ReadLine());
                            pokedex.Add(nuevoPokemon);
                            Console.WriteLine("Pokemon registrado con éxito papu :v");

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Por favor, ingresa valores numéricos válidos para Nivel y PC");
                        }
                        break;
                    case "2":
                        // TODO: Mostrar todos los elementos de la lista
                        if (pokedex.Count == 0)
                        {
                            Console.WriteLine("La pokédex esta vacía");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Lista de Pokémon ---");
                            foreach (Pokemon p in pokedex)
                            {
                                Console.WriteLine($"Nombre: {p.nombre} | Nivel: {p.nivel} | PC: {p.poderDeCombate}");
                            }
                        }
                        break;
                    case "3":
                        // TODO: Calcular y mostrar promedio de PC y Nivel
                        if (pokedex.Count == 0)
                        {
                            Console.WriteLine("No hay elemento para calcular el promedio");
                        }
                        else
                        {
                            double sumaPC = 0;
                            double sumaNivel = 0;
                            foreach (Pokemon p in pokedex)
                            {
                                sumaNivel += p.nivel;
                                sumaPC += p.poderDeCombate;
                            }
                            double promedioNivel = sumaNivel / pokedex.Count;
                            double promedioPC = sumaPC / pokedex.Count;
                            Console.WriteLine($"El promedio de Nivel de tu pokedex es: {promedioNivel:F2}");
                            Console.WriteLine($"El promedio de PC de tu pokédex es: {promedioPC:F2}");
                            
                        }
                        break;
                    case "4":
                        // TODO: Buscar elemento por nombre
                        Console.WriteLine("Ingrese el nombre del pokemon");
                        string nombrePokemon = Console.ReadLine();
                        foreach (Pokemon p in pokedex)
                        {
                            if (p.nombre == nombrePokemon)
                            {
                                Console.WriteLine($"{nombrePokemon} esta registrado!");
                            }
                            else
                            {
                                Console.WriteLine($"{nombrePokemon} no esta registrado");
                            }
                        }
                        break;
                    case "5":
                        // TODO: Filtrar y mostrar elementos > promedio
                        if (pokedex.Count == 0)
                        {
                            Console.WriteLine("La pokédex está vacía.");
                        }
                        else
                        {
                            double sumaPC = 0;

                            foreach (Pokemon p in pokedex)
                            {
                                sumaPC += p.poderDeCombate;
                            }

                            double promedioPC = sumaPC / pokedex.Count;

                            Console.WriteLine($"Promedio de PC: {promedioPC:F2}");
                            Console.WriteLine("Pokémon que superan el promedio:");

                            foreach (Pokemon p in pokedex)
                            {
                                if (p.poderDeCombate > promedioPC)
                                {
                                    Console.WriteLine($"Nombre: {p.nombre} | Nivel: {p.nivel} | PC: {p.poderDeCombate}");
                                }
                            }
                        }
                        break;
                    case "6":
                        // TODO: Encontrar max y min de PC
                        if (pokedex.Count == 0)
                        {
                            Console.WriteLine("La lista esta vacía.");
                        }
                        else
                        {
                            Pokemon maxPokemon = pokedex[0];
                            Pokemon minPokemon = pokedex[0];
                            foreach (Pokemon p in pokedex)
                            {
                                if (p.poderDeCombate > maxPokemon.poderDeCombate)
                                {
                                    maxPokemon = p;
                                }
                                if (p.poderDeCombate < minPokemon.poderDeCombate)
                                {
                                    minPokemon = p;
                                }
                            }
                            Console.WriteLine($"Máximo PC: {maxPokemon.nombre} con {maxPokemon.poderDeCombate}");
                            Console.WriteLine($"Mínimo PC: {minPokemon.nombre} con {minPokemon.poderDeCombate}");
                        }

                        break;
                    case "7":
                        // TODO: Eliminar elemento por nombre
                        break;
                    case "8":
                        ejecutar = false;
                        Console.WriteLine("¡Hasta la próxima, entrenador!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}