using System;
public class AppCampeonato
{
	public static void Main(string []a){
		
		Equipo e1 = new Equipo(); // id_ 1
		Equipo e2 = new Equipo(2, "Universitario", 10);
		Equipo e3 = new Equipo(3, "Boca Juniors");
		Equipo e4 = new Equipo("Real Madrid"); // id_ 4
		Equipo e5 = new Equipo(5); // id_ 5
		
		e1.mostrar();
		e2.mostrar();
		e3.mostrar();
		e4.mostrar();
		e5.mostrar();
		
		Campeonato c = new Campeonato();
		c.mostrar();
		
		Console.WriteLine("SOLUCION C");
		if(c.verificarEquipo(e1)){
			Console.WriteLine("si participo");
		}else{
			Console.WriteLine("no participo");
		}
		
		if(c.verificarEquipo(e5)){
			Console.WriteLine("si participo");
		}else{
			Console.WriteLine("no participo");
		}
		
		c.verificarEquipo_2(e1);
		c.verificarEquipo_2(e5);
		
		Console.WriteLine("\nsolucion d");
		c.puntosGanadosEquipoX(e1);
		c.puntosGanadosEquipoX(e2);
		c.puntosGanadosEquipoX(e3);
		c.puntosGanadosEquipoX(e4);
		c.puntosGanadosEquipoX(e5);
		
		Console.WriteLine("\nsolucion e");
		c.adicionarPartido(e5.getId().ToString(), e1.getId().ToString(), "4", "3", "12/12/2023", "Mateo");
		c.mostrar();
		
		Console.WriteLine("\nsolucion f");
		c.ordenar();
		c.mostrar();
		
		string cad = "hola";
		string cad2 = "hola";
		// -1  cuando es menor
		// 1 (cuando es mayor
		// 0 (son iguales
		Console.WriteLine(cad2.CompareTo(cad));
		
		Console.WriteLine("\nsolucion g");
		c.eliminarPartido("Mateo");
		c.mostrar();
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
	
	
}

