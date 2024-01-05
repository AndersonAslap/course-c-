using System.Collections;

/*
Console.WriteLine("---- Variáveis ----");

int age = 33;
Console.WriteLine(age);

string name = "Anderson Paiva";
Console.WriteLine(name);

decimal price = 200.99m;
Console.WriteLine(price);

double priceDouble = 200.99;
Console.WriteLine(priceDouble);

float priceFloat = 200.99f;
Console.WriteLine(priceFloat);

var newAge = 25;
Console.WriteLine(newAge);

char flag = 'Y';
Console.WriteLine(flag);

bool active = true;
Console.WriteLine(active); 

Console.WriteLine("---- Constantes ----");

const string description = "Curso CSHARP";
Console.WriteLine(description);
*/

/*
Console.WriteLine("---- Operadores Aritmétricos ----");

int number1 = 1;
var number2 = 2;

var sum = number1 + number2;
Console.WriteLine(sum);

var sub = number2 - number1;
Console.WriteLine(sub);

var mult = number2 * number1;
Console.WriteLine(mult);

var divided = number2 / number1;
Console.WriteLine(divided);
*/

/*
Console.WriteLine("---- Operadores Relacionais ----");

int number1 = 1;
var number2 = 2;

bool equal = number1 == number2;
Console.WriteLine(equal);

bool diference = number1 != number2;
Console.WriteLine(equal);

bool greater = number1 > number2;
Console.WriteLine(greater);

bool lesser = number1 < number2;
Console.WriteLine(lesser);

bool greaterOrEqual = number1 >= number2;
Console.WriteLine(greaterOrEqual);

bool lesserOrEqual = number1 <= number2;
Console.WriteLine(lesserOrEqual);
*/

/*
Console.WriteLine("---- Operadores Lógicos ----");

int number1 = 1;
var number2 = 2;

bool valid = number2 > number1 && 8 > 7;
Console.WriteLine(valid);

bool valid2 = number2 > number1 && 6 > 7;
Console.WriteLine(valid2);

bool valid3 = number2 > number1 || 6 > 7;
Console.WriteLine(valid3);

bool valid4 = number2 < number1 || 6 > 7;
Console.WriteLine(valid4);

bool valid5 = !(number1 > 10);
Console.WriteLine(valid5);

bool valid6 = !(number1 < 10);
Console.WriteLine(valid6);
*/

/*
Console.WriteLine("---- Operadores Ternário ----");

int number1 = 1;
var number2 = 2;

bool active = true;
string status = active ? "Cadastro ativo" : "Cadastro Inativo" ;
Console.WriteLine(status);
*/

/*
Console.WriteLine("---- Funções ----");

var calc = Sum(1,6);
Console.WriteLine(calc);

WriteName();

string FullName(string firstName, string lastName)
{
    return firstName + " " + lastName;
}

int Sum(int number1, int number2)
{
    return number1 + number2;
}

void WriteName() 
{
    var name = FullName("Anderson", "Paiva");
    Console.WriteLine(name);
}
*/

//Console.WriteLine("---- Tipos de dados ----");

/*
Console.WriteLine("---- Array List ----");

var arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Aslap");
arrayList.Add(true);
Console.WriteLine(arrayList[1]);

arrayList.RemoveAt(1);

WriteFullCollection(arrayList);

// arrayList = new ArrayList();
arrayList.Clear();
*/

/*
Console.WriteLine("---- Array Tipado ----");

//var arrayTipadoInt = new int[3] {1, 2, 3};
var arrayTipadoInt = new int[3];

arrayTipadoInt[0] = 1;
arrayTipadoInt[1] = 2;
arrayTipadoInt[2] = 3;

Array.Resize(ref arrayTipadoInt, 11);

arrayTipadoInt[10] = 10;

WriteFullCollection(arrayTipadoInt);

var arrayTipadoString = new string[3] {"Anderson", "Adolfo", "Paiva"};

WriteFullCollection(arrayTipadoString);
*/

/*
Console.WriteLine("---- Lista Genérica ----");

var lista = new List<string>(10)
{
    "Aslap",
    "Adolfo",
};

lista.Add("Aslap");
lista.Add("Adolfo");

lista.RemoveAt(1);

WriteFullCollection(lista);
*/

/*
Console.WriteLine("---- Dicionário ----");

var dicionary = new Dictionary<int, string>()
{
    {5, "Teste"}
};

dicionary.Add(1, "Aslap");

dicionary[50] = "Curso";

WriteFullCollection(dicionary);

var dicionary2 = new Dictionary<string, string>()
{
    {"a", "Teste"}
};

dicionary2.Add("b", "Aslap");

dicionary2["c"] = "Curso";

WriteFullCollectionDictionary(dicionary2);
*/

/*
Console.WriteLine("---- Queue FIFO ----");

var queue = new Queue<string>();
queue.Enqueue("Anderson");
queue.Enqueue("Paiva");

var name = queue.Peek();
Console.WriteLine(name);

var name2 = queue.Dequeue();
Console.WriteLine(name2);

WriteFullCollection(queue);
*/

/*
Console.WriteLine("---- Stack LIFO ----");

var stack = new Stack<string>();
stack.Push("Aslap");
stack.Push("Adolfo");

var name = stack.Peek();
Console.WriteLine(name);

var name2 = stack.Pop();
Console.WriteLine(name2);

WriteFullCollection(stack);

void WriteFullCollection<T>(IEnumerable<T> collection)
{
    foreach(var item in collection)
    {
        Console.WriteLine(item);
    }
}

void WriteFullCollectionDictionary(Dictionary<string, string> collection)
{
    foreach(var item in collection)
    {
        Console.WriteLine(item.Key);
        Console.WriteLine(item.Value);
    }
}
*/