// See https://aka.ms/new-console-template for more information
var text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore," +
    " nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum." +
    " Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere," +
    " reiciendis voluptate maiores! Repellat, dolorum!";
var sentense=text.Split(  ' ' );
foreach (var sentrnse in sentense) ;
Console.WriteLine(sentense);

var words=text.Split( " ",10 );
foreach (var word in words) 
    Console.WriteLine(word);