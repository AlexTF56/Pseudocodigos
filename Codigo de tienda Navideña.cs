﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_equipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de adornos navideños");
            Console.WriteLine("Cual es tu nombre");
            string nombre = Console.ReadLine();
            var lista = new ArrayList();
            var suma = new int();
            suma = 0;

            Console.WriteLine("Bienvenido al almacen " + nombre);
            Console.WriteLine("Deseas ver los productos, coloca 'SI' o 'NO' ");

            string respuesta = Console.ReadLine();
            while (respuesta.ToLower() != "no" && respuesta.ToLower() != "si")
            {
                Console.WriteLine("Solo puedes escojer 'SI' o 'NO' ");
                respuesta = Console.ReadLine();
            }
            while (respuesta.ToLower() != "no")
            {

                var completo = new ArrayList();
                string[] productos = { "Arboles", "Esferas", "Muñecos", "Manteles", "luces", "tapetes", "bolsa de dulces", "disfraces" };
                string[,] subproductos = { { "Natural", "Artificial" }, { "cristal", "plastico" }, { "Tela", "Plastico" }, { "Rayas", "Lisos" }, { "RGB", "Color fijo" }, { "Tela", "plastico" }, { "Especifico", "Surtido" }, { "Hombnre", "Mujer" } };
                string[,,] tamaño =

                    { { { "chico", "mediano", "grande" }, { "chico", "mediano", "grande" } },
                { { "24pz a solo $350", "12pz a solo $270", "6pz a solo $190" }, { "24pz a solo $290", "12pz a solo $220", "6pz a solo $140" } },
                { { "chico a solo $650", "mediano a solo $780", "grande a solo $930" }, { "chico a solo $550", "mediano a solo $820", "grande a solo $990" } },
                { { "chico a solo $250", "mediano a solo $300", "grande a solo $350" }, { "chico a solo $250", "mediano a solo $300", "grande a solo $350" } },
                { { "chico a solo $850", "mediano a solo $1000", "grande a solo $1250" }, { "chico a solo $660", "mediano a solo $780", "grande a solo $925" } },
                { { "chico a solo $150", "mediano a solo $200", "grande a solo $250" }, { "chico a solo $150", "mediano a solo $200", "grande a solo $250" } },
                { { "chico a solo $175", "mediano a solo $230", "grande a solo $300" }, { "chico a solo $120", "mediano a solo $180", "grande a solo $245" } },
                { { "chico a solo $850", "mediano a solo $900", "grande a solo $950" }, { "chico a solo $850", "mediano a solo $900", "grande a solo $950" } } };

                string[,,,] colores =

                    { { { { "Pino Oyamel $3450", "Pino Vikingo $3450", "Pino Cedro Blanco $3450" }, { "Pino Oyamel $4760", "Pino Vikingo $4760", "Pino Cedro Blanco $4760" }, { "Pino Oyamel $5500", "Pino Vikingo $5500", "Pino Cedro Blanco $5500" } }, { { "Verde $2340", "Blanco $2340", "Rosa $2340" }, { "Verde $3100", "Blanco $3100", "Rosa $3100" }, { "Verde $4050", "Blanco $4050", "Rosa $4050" } } },
                { { { "Roja - Blanca", "Negra - Blanca", "Dorado" }, { "Roja - Blanca", "Negra - Blanca", "Dorado" }, { "Roja - Blanca", "Negra - Blanca", "Dorado" } }, { { "Roja", "Azul", "Dorado" }, { "Roja", "Azul", "Dorado" }, { "Roja", "Azul", "Dorado" } } },
                { { { "Santa Claus", "Muñeco de Nieve", "Reno" }, { "Santa Claus", "Muñeco de Nieve", "Reno" }, { "Santa Claus", "Muñeco de Nieve", "Reno" } }, { { "Santa Claus", "Muñeco de Nieve", "Reno" }, { "Santa Claus", "Muñeco de Nieve", "Reno" }, { "Santa Claus", "Muñeco de Nieve", "Reno" } } },
                { { { "Blanco-Rojo", "Azul-Plata", "Dorado-Rojo" }, { "Blanco-Rojo", "Azul-Plata", "Dorado-Rojo" }, { "Blanco-Rojo", "Azul-Plata", "Dorado-Rojo" } }, { { "Azul", "Rojo", "Dorado" }, { "Azul", "Rojo", "Dorado" }, { "Azul", "Rojo", "Dorado" } } },
                { { { "Focos", "Musical", "Manguera" }, { "Focos", "Musical", "Manguera" }, { "Focos", "Musical", "Manguera" } }, { { "Focos", "Cascada", "Manguera" }, { "Focos", "Cascada", "Manguera" }, { "Focos", "Cascada", "Manguera" } } },
                { { { "Rojo", "Blanco", "Verde" }, { "Rojo", "Blanco", "Verde" }, { "Rojo", "Blanco", "Verde" } }, { { "Rojo", "Blanco", "Verde" }, { "Rojo", "Blanco", "Verde" }, { "Rojo", "Blanco", "Verde" } } },
                { { { "Paletas", "Barra Chocolate", "Baston de caramelo" }, { "Paletas", "Barra Chocolate", "Baston de caramelo" }, { "Paletas", "Barra Chocolate", "Baston de caramelo" } }, { { "Surtido Chocolates", "Surtido Cgocolates y caramelos", "Surtido Caramelo" }, { "Surtido Chocolates", "Surtido chocolate y caramelo", "Surtido Caramelo" }, { "Surtido Chocolates", "Surtido chocolate y caramelo", "Surtido Caramelo" } } },
                { { { "Pinguino", "Santa Claus", "Grinch" }, { "Pinguino", "Santa Claus", "Grinch" }, { "Pinguino", "Santa Claus", "Grinch" } }, { { "Pinguino", "Santa Claus", "Grinch" }, { "Pinguino", "Santa Claus", "Grinch" }, { "Pinguino", "Santa Claus", "Grinch" } } } };

                string[,,,] precios =

                    { { { { "3450", "3450", "3450" }, { "4760", "4760", "4760" }, { "5500", "5500", "5500" } }, { { "2340", "2340", "2340" }, { "3100", "3100", "3100" }, { "4050", "4050", "4050" } } },
                { { { "350", "350", "350" }, { "270", "270", "270" }, { "190", "190", "190" } }, { { "290", "290", "290" }, { "220", "220", "220" }, { "140", "140", "140" } } },
                { { { "650", "650", "650" }, { "780", "780", "780" }, { "930", "930", "930" } }, { { "550", "550", "550" }, { "820", "820", "820" }, { "990", "990", "990" } } },
                { { { "250", "250", "250" }, { "300", "300", "300" }, { "350", "350", "350" } }, { { "250", "250", "250" }, { "300", "300", "300" }, { "350", "350", "350" } } },
                { { { "850", "850", "850" }, { "1000", "1000", "1000" }, { "1250", "1250", "1250" } }, { { "660", "660", "660" }, { "$780", "$780", "$780" }, { "925", "925", "925" } } },
                { { { "150", "150", "150" }, { "200", "200", "200" }, { "250", "250", "250" } }, { { "150", "150", "150" }, { "200", "200", "200" }, { "250", "250", "250" } } },
                { { { "175", "175", "175" }, { "230", "230", "230" }, { "300", "300", "300" } }, { { "120", "120", "120" }, { "180", "180", "180" }, { "245", "245", "245" } } },
                { { { "850", "850", "850" }, { "900", "900", "900" }, { "950", "950", "950" } }, { { "850", "850", "850" }, { "900", "900", "900" }, { "950", "950", "950" } } } };


                Console.WriteLine("Selecciona un producto de la lista");
                for (int i = 0; i < productos.Length; i++)
                {
                    Console.WriteLine(i + ".-" + productos[i]);
                }
                bool comprobar = true;
                int seleccion1 = 0;
                while (comprobar)
                {
                    try
                    {
                        string selec1 = Console.ReadLine();
                        seleccion1 = int.Parse(selec1);
                        while (seleccion1 > 7 || seleccion1 < 0)
                        {
                            Console.WriteLine("Solo puedes escojer del '0' al '7' ");
                            selec1 = Console.ReadLine();
                            seleccion1 = int.Parse(selec1);
                        }
                        comprobar = false;
                    }
                    catch { Console.WriteLine("Solo puedes escojer numeros del '0' al '7' "); }
                }
                completo.Add(productos[seleccion1]);
                Console.Clear();

                Console.WriteLine("Selecciona el tipo: ");

                for (int j = 0; j < subproductos.GetLength(1); j++)
                {
                    Console.WriteLine(j + ".-" + subproductos[seleccion1, j]);
                }
                bool comprobar2 = true;
                int seleccion2 = 0;
                while (comprobar2)
                {
                    try
                    {
                        string selec1 = Console.ReadLine();
                        seleccion2 = int.Parse(selec1);
                        while (seleccion2 > 1 || seleccion2 < 0)
                        {
                            Console.WriteLine("Solo puedes escojer del '0' al '1' ");
                            selec1 = Console.ReadLine();
                            seleccion2 = int.Parse(selec1);
                        }
                        comprobar2 = false;
                    }
                    catch { Console.WriteLine("Solo puedes escojer numeros del '0' al '1' "); }
                }
                completo.Add(subproductos[seleccion1, seleccion2]);
                Console.Clear();

                Console.WriteLine("Selecciona el tamaño: ");

                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine(k + ".-" + tamaño[seleccion1, seleccion2, k]);
                }
                bool comprobar3 = true;
                int seleccion3 = 0;
                while (comprobar3)
                {
                    try
                    {
                        string selec1 = Console.ReadLine();
                        seleccion3 = int.Parse(selec1);
                        while (seleccion3 > 2 || seleccion3 < 0)
                        {
                            Console.WriteLine("Solo puedes escojer del '0' al '2' ");
                            selec1 = Console.ReadLine();
                            seleccion3 = int.Parse(selec1);
                        }
                        comprobar3 = false;
                    }
                    catch { Console.WriteLine("Solo puedes escojer numeros del '0' al '2' "); }
                }
                completo.Add(tamaño[seleccion1, seleccion2, seleccion3]);
                Console.Clear();

                for (int l = 0; l < 3; l++)
                {
                    Console.WriteLine(l + ".-" + colores[seleccion1, seleccion2, seleccion3, l]);
                }
                bool comprobar4 = true;
                int seleccion4 = 0;
                while (comprobar4)
                {
                    try
                    {
                        string selec1 = Console.ReadLine();
                        seleccion4 = int.Parse(selec1);
                        while (seleccion4 > 2 || seleccion3 < 0)
                        {
                            Console.WriteLine("Solo puedes escojer del '0' al '2' ");
                            selec1 = Console.ReadLine();
                            seleccion4 = int.Parse(selec1);
                        }
                        comprobar4 = false;
                    }
                    catch { Console.WriteLine("Solo puedes escojer numeros del '0' al '2' "); }
                }
                completo.Add(colores[seleccion1, seleccion2, seleccion3, seleccion4]);
                lista.Add(completo);
                suma += Int32.Parse(precios[seleccion1, seleccion2, seleccion3, seleccion4]);
                Console.Clear();

                Console.WriteLine("Seleccionaste : " + completo[0] + " " + completo[1] + " " + completo[2] + " " + "en color/estilo" + " " + completo[3]);
                Console.WriteLine("El precio es: " + precios[seleccion1, seleccion2, seleccion3, seleccion4] + " " + "pesos mexicanos");
                Console.WriteLine("El acumulado es $" + suma);
                Console.WriteLine("Deseas seguir comprando, escribe 'SI', si asi lo deseas o escribe 'NO', si es que deseas finalizar tu compra");
                respuesta = Console.ReadLine();

                while (respuesta.ToLower() != "no" && respuesta.ToLower() != "si")
                {
                    Console.WriteLine("Solo puedes escojer 'SI' o 'NO' ");
                    respuesta = Console.ReadLine();
                }

            }
            Console.WriteLine("Tu lista de articulos son : ");
            foreach (ArrayList elemento in lista)
            {
                Console.WriteLine(" " + elemento[0] + " " + elemento[1] + " " + elemento[2] + " " + "en color/estilo" + " " + elemento[3]);
            }
            Console.WriteLine("El total es: $ " + suma);
            Console.WriteLine("");
            Console.WriteLine("¡Gracias por tu compra! Vuelve pronto :)");
            Console.ReadLine();
        }
    }
}