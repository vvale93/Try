<Query Kind="Statements" />



bool finDeSemana, viernes, entradaBarata;
bool voyAlCine;

int precioEntrada = 40;

DateTime fecha;

//	fecha = DateTime.Now;
fecha = new DateTime(2016, 10, 8);

entradaBarata = precioEntrada < 50;

viernes = fecha.DayOfWeek == DayOfWeek.Friday;

finDeSemana = fecha.DayOfWeek == DayOfWeek.Saturday | fecha.DayOfWeek == DayOfWeek.Sunday;

voyAlCine = ( viernes | finDeSemana ) & entradaBarata ;

voyAlCine.Dump();