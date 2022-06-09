using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisguras_Geometricas
{
    class Figuras
    {
                                        public string Name { get; set; }
                                        public string Color { get; set; }
                                                            public Figuras(string Name, string Color) 

                                                            {
                                                                this.Name = Name;

                                                                this.Color = Color;

                                                            }
                                                                                    public void Mostrar_Datos()
                                                                                    {

                                                                                        Console.WriteLine("Nombre: " + Name);

                                                                                        Console.WriteLine("Color: " + Color);

                                                                                    }
    }
}
