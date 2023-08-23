using N28_HT2;

var list = new ClonableList<StorageFile>
{
    new StorageFile("Pubg","Game",700)
};
var newList = (ClonableList<StorageFile>)list.Clone();
foreach (var item in newList)
{
    Console.WriteLine(item);

}
