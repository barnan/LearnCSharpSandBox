// See https://aka.ms/new-console-template for more information
using Learn_Class_2;

InitExample person = new InitExample(prop2 : 30) { Prop1 = 1, _valami1 = 50 };

Struct1 str1 = new Struct1();

Struct1.DoSomething();



AnotherDerivedClass adc = new AnotherDerivedClass();
AnotherDerivedClass.DoSomething1();
DerivedClass dc = adc;
BaseClass bc = adc;

Console.WriteLine(Environment.NewLine);

bc.DoSomething3();      // a DerievdClass-ban lévő new miatt úgy viselkedik mintha bc lenne
dc.DoSomething3();      // a new miatt a DerivedClass metódusa hívódik
adc.DoSomething3();     // a new miatt a DerivedClass metódusa hívódik, adc-nek nincs ilyen metódusa

bc.DoSomething2();      // override miatt a DerivedClass hivodik , a new miatt nem megy az AnotherDerivedClass-ba
dc.DoSomething2();      // DerievdClass metódusa hívódik
adc.DoSomething2();     // adc metódusa hívódik

Console.ReadKey();