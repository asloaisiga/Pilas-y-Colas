using System;
using System.Collections.Generic;

namespace SimulacionUndo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> acciones = new Stack<string>();
            const int MAX_ACCIONES = 5;

            Console.WriteLine("=== Simulación de 'Deshacer' (Undo) ===\n");

            // 1. Permitir al usuario ingresar cinco acciones válidas
            for (int i = 1; i <= MAX_ACCIONES; i++)
            {
                string accion;
                do
                {
                    Console.Write($"Ingrese la acción #{i} (Ej: 'Escribir palabra', 'Borrar línea'): ");
                    accion = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(accion))
                    {
                        Console.WriteLine(" La acción no puede estar vacía. Intente de nuevo.\n");
                    }
                } while (string.IsNullOrWhiteSpace(accion));

                acciones.Push(accion);
                Console.WriteLine($" Acción registrada: {accion}\n");
            }

            // 2. Mostrar todas las acciones almacenadas
            Console.WriteLine("\n Acciones registradas (de más reciente a más antigua):");
            MostrarPila(acciones);

            // 3. Simular la acción 
            Console.WriteLine("\n¿Desea deshacer la última acción? (S/N): ");
            string respuesta = Console.ReadLine()?.Trim().ToUpper();

            if (respuesta == "S")
            {
                if (acciones.Count > 0)
                {
                    string ultima = acciones.Pop();
                    Console.WriteLine($"\n↩ Acción deshecha: {ultima}");
                }
                else
                {
                    Console.WriteLine("\n  No hay acciones para deshacer.");
                }
            }
            else
            {
                Console.WriteLine("\nNo se realizó ninguna acción de deshacer.");
            }

            // 4. Mostrar el estado de la pila después del deshacer
            Console.WriteLine("\n Estado actual de la pila:");
            MostrarPila(acciones);

            // 5. Verificar si la pila está vacía
            if (acciones.Count == 0)
                Console.WriteLine("\n No hay más acciones por deshacer (pila vacía).");
            else
                Console.WriteLine($"\n Quedan {acciones.Count} acciones por deshacer.");

            Console.WriteLine("\n=== Fin del programa ===");
        }

        // Método auxiliar para mostrar el contenido de la pila
        static void MostrarPila(Stack<string> pila)
        {
            if (pila.Count == 0)
            {
                Console.WriteLine("(vacía)");
                return;
            }

            int index = 1;
            foreach (var accion in pila)
            {
                Console.WriteLine($"{index}. {accion}");
                index++;
            }
        }
    }
}
