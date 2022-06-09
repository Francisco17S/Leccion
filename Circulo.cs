using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisguras_Geometricas
{
    class Circulo: Figuras, IFiguras
    {

                                public double PI_Circulo =3.1416;
                                public double Radio_Circulo { get; set; }

                                                            public Circulo(string Name, string Color, double PI_Circulo): base(Name, Color)
                                                            {

                                                                this.Radio_Circulo = Radio_Circulo;

                                                            }
                                                                                                    public void Calcular_Area()
                                                                                                    {
                                                                                                        double Area_Circulo;

                                                                                                        Area_Circulo = PI_Circulo * Math.Pow(Radio_Circulo,2);

                                                                                                        Console.WriteLine("El area del circulo es: " + Area_Circulo);

                                                                                                    }

    }

}
