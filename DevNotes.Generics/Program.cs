using DevNotes.Generics;

var box = new Box<int>(7);
Console.WriteLine(box.GetContent());
box.Set(12);
Console.WriteLine(box.GetContent());


var box2 = new Box<bool>(true);
Console.WriteLine(box2.GetContent());
box2.Set(false);
Console.WriteLine(box2.GetContent());

