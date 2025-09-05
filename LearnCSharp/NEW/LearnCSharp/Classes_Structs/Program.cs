// See https://aka.ms/new-console-template for more information

using Classes_Structs;

Console.WriteLine("Program Started");

PrimaryConstr valtozo1 = new(20);
NormalConstr valtozo2 = new(30);

InitValtozo valtozo3 = new(20, 30, 30) { MyVar3 = 70, MyVar4 = 50 };
InitValtozo valtozo4 = new InitValtozo();

// csak init-je van, settere nincs ,ezért nem lehet később állítani, csak a object inicializálás során
//valtozo3.MyVar3 = 0d; 

Console.WriteLine("Program Ended");