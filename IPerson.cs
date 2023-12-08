public interface IPerson {
  string Name{ get; }
  int Age { get; }
}

class Test(string name): IPerson {
  public string Name { get; } = name;
  public int Age { get; }
}

class Test2(IPerson person) {
  public string Name { get; } = person.Name;
  public int Age { get; } = person.Age;
}

class Test3 {
  public string Name { get; }
  public int Age { get; }
  public Test3(IPerson person) {

  }
}