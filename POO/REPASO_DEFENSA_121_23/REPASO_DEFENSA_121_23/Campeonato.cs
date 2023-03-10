
using System;

public class Campeonato
{
	private string nombre;
	private int nro_partidos;
	private string [,]partidos = new string[100, 10];
	public Campeonato()
	{
		nombre = "los cachitos";
		nro_partidos = 4;
		partidos[1, 1] = "1";
		partidos[1, 2] = "2";
		partidos[1, 3] = "5";
		partidos[1, 4] = "3";
		partidos[1, 5] = "12/12/2023";
		partidos[1, 6] = "Juan";
		
		partidos[2, 1] = "2";
		partidos[2, 2] = "4";
		partidos[2, 3] = "0";
		partidos[2, 4] = "0";
		partidos[2, 5] = "01/02/2023";
		partidos[2, 6] = "Maria";
		
		partidos[3, 1] = "1";
		partidos[3, 2] = "3";
		partidos[3, 3] = "3";
		partidos[3, 4] = "3";
		partidos[3, 5] = "01/01/2023";
		partidos[3, 6] = "Mateo";
		
		
		partidos[4, 1] = "4";
		partidos[4, 2] = "3";
		partidos[4, 3] = "10";
		partidos[4, 4] = "0";
		partidos[4, 5] = "12/02/2023";
		partidos[4, 6] = "Alizon";
	}
	
	public void mostrar(){
		Console.WriteLine("CAMPEONATO");
		Console.WriteLine("nombre: " + nombre + "\nnro_part: " + nro_partidos + "\n");
		Console.WriteLine("PARTIDOS DEL CAMPEONATO");
		for(int i = 1; i <= nro_partidos; i++){
			for(int j = 1; j <= 6; j++){
				
				Console.Write(partidos[i, j] + "\t ");
			}
			Console.WriteLine();
		}
	}
	
	public bool verificarEquipo(Equipo eq){
		bool participo = false;
		for(int i = 1; i <= nro_partidos; ++i){
			
			int idEquipo1 = int.Parse(partidos[i, 1]);
			int idEquipo2 = int.Parse(partidos[i, 2]);
			if(idEquipo1 == eq.getId() || idEquipo2 == eq.getId()){
				participo = true;
			}
		}
		
		return participo;
	}
	
	public void verificarEquipo_2(Equipo eq){
		bool participo = false;
		for(int i = 1; i <= nro_partidos; ++i){
			
			int idEquipo1 = int.Parse(partidos[i, 1]);
			int idEquipo2 = int.Parse(partidos[i, 2]);
			if(idEquipo1 == eq.getId() || idEquipo2 == eq.getId()){
				participo = true;
			}
		}
		if(participo){
			Console.WriteLine("si participo");
		}else{
			Console.WriteLine("no participo");
		}
	}
	
	public void puntosGanadosEquipoX(Equipo x){
		int puntaje = 0;
		for(int i = 1; i <= nro_partidos; ++i){
			int idEquipo = int.Parse(partidos[i, 1]);
			if(x.getId() == idEquipo){
				int goles_eq1 = int.Parse(partidos[i, 3]);
				int goles_eq2 = int.Parse(partidos[i, 4]);
				if(goles_eq1 > goles_eq2){
					puntaje += 3;
				}else if(goles_eq1 == goles_eq2){
					puntaje += 1;
				}
			}
			
			idEquipo = int.Parse(partidos[i, 2]);
			if(x.getId() == idEquipo){
				int goles_eq1 = int.Parse(partidos[i, 4]);
				int goles_eq2 = int.Parse(partidos[i, 3]);
				if(goles_eq1 > goles_eq2){
					puntaje += 3;
				}else if(goles_eq1 == goles_eq2){
					puntaje += 1;
				}
			}

		}
		Console.WriteLine("El equipo " + x.getNombre() + " tiene " + puntaje + " puntos");
	}
	
	public void adicionarPartido(string id_eq1, string id_eq2, string gol_eq1, string gol_eq2, string fecha, string ar){
		nro_partidos++;
		partidos[nro_partidos, 1] = id_eq1;
		partidos[nro_partidos, 2] = id_eq2;
		partidos[nro_partidos, 3] = gol_eq1;
		partidos[nro_partidos, 4] = gol_eq2;
		partidos[nro_partidos, 5] = fecha;
		partidos[nro_partidos, 6] = ar;
		
				
	}
	
	public void ordenar(){
		for(int i = 1; i <= nro_partidos; i++){
			for(int j = i + 1; j <= nro_partidos; j++){
				if( partidos[i, 6].CompareTo(partidos[j, 6]) == 1){
					for(int k = 1; k <= 6; k++){
						string aux = partidos[i, k];
						partidos[i, k] = partidos[j, k];
						partidos[j, k] = aux;
					}
				}
			}
		}
	}
	
	public void eliminarPartido(string nombre){
		for(int i = 1; i <= nro_partidos; ++i){
			if(partidos[i, 6].Equals(nombre)){
				// puedo eliminar
				for(int j = i + 1; j <= nro_partidos; ++j){
					
					for(int k = 1; k <= 6; k++){
						partidos[j - 1, k] = partidos[j, k];
					}
				}
				
				nro_partidos--;
				i--; // cuando eliminamos, como esta recorriendo una posicion (esa posicion no lo revisa)
				// por eso es i--;
			}
		}
	}
	
}

