using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisguras_Geometricas
{
    class Rectangulo: Figuras, IFiguras
    {

                                                    public int Base_Rectangulo { get; set; }
                                                    public int Altura_Rectangulo { get; set; }

                                                                                public Rectangulo(string Name, string Color, int Base_Rectangulo, int Altura_Rectangulo) : base(Name, Color)
                                                                                {

                                                                                    this.Base_Rectangulo = Base_Rectangulo;

                                                                                    this.Altura_Rectangulo = Altura_Rectangulo;

                                                                                }
                                                                                                                                public void Calcular_Area()
                                                                                                                                {

                                                                                                                                    int Area_Rectangulo;

                                                                                                                                    Area_Rectangulo = Base_Rectangulo * Altura_Rectangulo;

                                                                                                                                    Console.WriteLine("El area del rectangulo es: " + Area_Rectangulo);

                                                                                                                                }
    }
}
