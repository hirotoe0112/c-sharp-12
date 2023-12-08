// プライマリコンストラクター
class Person(string name, int age){
  public string Name = name;
  public int Age = age;
  private string info = "";

  public string GetInfo() {
    if(String.IsNullOrWhiteSpace(info)){
      return "情報はありません";
    }
    return info;
  }

  public Person(): this("名無し", 0) { }
  public Person(string name): this(name, 0) { }
  public Person(int age): this("名無し", age) { }
  public Person(string name, int age, string info): this(name, age) {
    this.info = info;
  }
}