using InicializacionDeUnCarrito.clases;

Carro miCarrito = new Carro("Toyota", 2022, "azul");
Carro EstefaniCarrito = new Carro("Ferrari", 2022, "Rojo");
Carro Yesicacarrito = new Carro("Prado", 2015, "Blanco", 250);

if (miCarrito.Modelo > EstefaniCarrito.Modelo)
{
    Console.WriteLine("El carro del profe es mas reciente");
}
else
{
    Console.WriteLine("El carro de Estefani es mas reciente");
}

Console.WriteLine($"teacher car is {miCarrito.Marca}");
Console.WriteLine($"Estafani's car is {EstefaniCarrito.Marca}");
Console.WriteLine($"Estafani's model car is {EstefaniCarrito.Modelo}");

EstefaniCarrito.EncendidoMotor();
Console.WriteLine(EstefaniCarrito.GetVelocidadActual());
//EstefaniCarrito.EncendidoMotor();


for (int i = 0; i < 5; i++)
{
    EstefaniCarrito.acelerar();

}




for (int i = 0; i < 3; i++)
{

    EstefaniCarrito.desacelerar();

}

for (int i = 0; i < 5; i++)
{

    EstefaniCarrito.frenar();

}

EstefaniCarrito.apagarmotor();
EstefaniCarrito.apagarmotor();
EstefaniCarrito.EncendidoMotor();
EstefaniCarrito.Bocinar();

Console.WriteLine("\n");
Console.WriteLine("Carro de Yesica");
Console.WriteLine($"Marca: {Yesicacarrito.Marca}");
Console.WriteLine($"Modelo: {Yesicacarrito.Modelo}");
Console.WriteLine($"Color: {Yesicacarrito.Color}");
Console.WriteLine($"Velocidad Maxima : {Yesicacarrito.VMaxima} KM/H");

Yesicacarrito.EncendidoMotor();
Yesicacarrito.EncendidoMotor();
Console.WriteLine(Yesicacarrito.GetVelocidadActual());

for (int i = 0; i < 15; i++)
{
    Yesicacarrito.acelerar();
}
for (int i = 0; i < 10; i++)
{
    Yesicacarrito.desacelerar();
}
for (int i = 0; i < 10; i++)
{
    Yesicacarrito.frenar();
}
Yesicacarrito.apagarmotor();
Yesicacarrito.apagarmotor();
Yesicacarrito.EncendidoMotor();
Yesicacarrito.Bocinar();

