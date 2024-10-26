using DevNotes.Generics;

var box = new Box<int>(7);
var box2 = new Box<bool>(true);

Console.WriteLine(box.GetContent());
Console.WriteLine(box2.GetContent());