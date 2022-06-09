using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisguras_Geometricas
{
    class Cuadrado : Figuras, IFiguras
    {

                                             public int Lados_Cuadrado { get; set; }

                                                                        public Cuadrado(string Name, string Color, int Lados_Cuadrado): base (Name, Color)
                                                                        {

                                                                            this.Lados_Cuadrado = Lados_Cuadrado;

                                                                        }
                                                                                                                public void Calcular_Area()
                                                                                                                {
                                                                                                                    int Area_Cuadrado;

                                                                                                                    Area_Cuadrado = Lados_Cuadrado * 4;

                                                                                                                    Console.WriteLine("El area del cuadrado es: " + Area_Cuadrado);

                                                                                                                }
    }

}
