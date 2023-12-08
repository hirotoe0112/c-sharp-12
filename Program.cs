// 任意の型の名前設定
using PersonType = (string name, int age);
using CustomString = System.String;

// コレクション式
Console.WriteLine("=-=-=-=- コレクション式 -=-=-=-=");
List<int> intList = [1,2,3,4,5];
int[] intArray = [1,2,3,4,5];
int[][] intArray2 = [[1,2,3],[4,5,6]];

// スプレッド演算子
Console.WriteLine("=-=-=-=- スプレッド演算子 -=-=-=-=");
List<int> intList2 = [..intList, 6, 7, 8, ..intArray];
Console.WriteLine(intList2);
int[][] intArray3 = [..intArray2, [7,8,9]];
Console.WriteLine(intArray3);

// usingで定義した名前
Console.WriteLine("=-=-=-=- usingで定義した名前 -=-=-=-=");
PersonType onePerson = ("yamada", 10);
Console.WriteLine(onePerson.name);
Console.WriteLine(onePerson.age);
var a = CustomString.Concat("aaa", "bbb");
Console.WriteLine(a);

// ラムダ式の既定パラメーター
Console.WriteLine("=-=-=-=- ラムダ式の既定パラメーター -=-=-=-=");
var sampleLambda = (string name = "名無し") => {
  Console.WriteLine(name);
};
sampleLambda("hogehoge");
sampleLambda();

// プライマリコンストラクター
Console.WriteLine("=-=-=-=- プライマリコンストラクター -=-=-=-=");
var person = new Person("yamada", 10);
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
Console.WriteLine(person.GetInfo());

var person2 = new Person();
Console.WriteLine(person2.Name);
Console.WriteLine(person2.Age);
Console.WriteLine(person2.GetInfo());

var person3 = new Person("yamada");
Console.WriteLine(person3.Name);
Console.WriteLine(person3.Age);
Console.WriteLine(person3.GetInfo());

var person4 = new Person(20);
Console.WriteLine(person4.Name);
Console.WriteLine(person4.Age);
Console.WriteLine(person4.GetInfo());

var person5 = new Person("sato", 15, "hogehoge");
Console.WriteLine(person5.Name);
Console.WriteLine(person5.Age);
Console.WriteLine(person5.GetInfo());

var test = new Test("suzuki");
Console.WriteLine(test.Name);
Console.WriteLine(test.Age);