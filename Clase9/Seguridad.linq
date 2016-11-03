<Query Kind="Program">
  <Reference Relative="Datos.dll">F:\CURSO_EMPLEAR\src_git\Clase9\Datos.dll</Reference>
  <Reference Relative="Newtonsoft.Json.dll">F:\CURSO_EMPLEAR\src_git\Clase9\Newtonsoft.Json.dll</Reference>
  <Namespace>Datos</Namespace>
</Query>


void Main()
{
  Database db = new Database();
  
  //  db.Provincias.Dump();
  db.Localidades.Dump();
}


public class Database
{
  public List<Provincia> Provincias { get { return Datos.Info.Provincias; } }

  public List<Localidad> Localidades { get { return Datos.Info.Localidades; }}
  
  
}

