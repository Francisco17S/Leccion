using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisguras_Geometricas
{
    class Program
    {
        public static void Main(String[] args)
        {
            Cuadrado Datos_Cuadrado = new Cuadrado("Cuadrado", "Cyan",12);
            Datos_Cuadrado.Mostrar_Datos();


                                            Rectangulo Datos_Rectangulo = new Rectangulo("Rectangulo", "Magenta", 2, 4);
                                            Datos_Rectangulo.Mostrar_Datos();


                                                                            Circulo Datos_Circulo = new Circulo("Circulo", "Negro", 5);
                                                                            Datos_Circulo.Mostrar_Datos();


                                                                                                            List<Figuras> ListaGeometrica = new List<Figuras>();

                                                                                                                            ListaGeometrica.Add(Datos_Cuadrado);
                                                                                                                            ListaGeometrica.Add(Datos_Rectangulo);
                                                                                                                            ListaGeometrica.Add(Datos_Circulo);



                                                                                                                                                                foreach (IFiguras item in ListaGeometrica)
                                                                                                                                                                        {
                                                                                                                                                                            item.Calcular_Area();
                                                                                                                                                                        }

        }

    }

}
