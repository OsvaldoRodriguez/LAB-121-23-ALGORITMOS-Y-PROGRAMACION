using System;
public class Equipo
{
	private int id_equipo;
	private string nombre;
	private int nro_jugadores;
	
	public Equipo(){ // constructor por defecto
		id_equipo = 1;
		nombre = "Bolivar";
		nro_jugadores = 11;
	}
	
	public Equipo(int id, string nom, int jugadores){
		id_equipo = id;
		nombre = nom;
		nro_jugadores = jugadores;
	}
	
	
	public Equipo(int id, string nom){
		id_equipo = id;
		nombre = nom;
		nro_jugadores = 15;
	}
	
	public Equipo(string nom){
		id_equipo = 4;
		nombre = nom;
		nro_jugadores = 30;
	}
	public Equipo(int id){
		id_equipo = 5;
		nombre = "Aurora";
		nro_jugadores = 2;
	}
	
	
	public void mostrar(){
		Console.WriteLine("EQUIPO");
		Console.WriteLine("id: " + id_equipo + "\nnombre: " + nombre + "\nnro_jug: " + nro_jugadores + "\n");
	}
	
	public int getId(){
		return id_equipo;
	}
	
	public string getNombre(){
		return nombre;
	}
	
	
	~Equipo(){
		
	}
}
