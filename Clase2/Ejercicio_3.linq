<Query Kind="Statements" />

bool A, B, C, D;
int año = 2017;

A = año % 4 == 0;
B = año % 100 == 0;
C = año % 400 == 0;

Console.WriteLine ("{0} - {1} - {2}", A, B, C);

D = (A && !B) || C;

Console.WriteLine (D);