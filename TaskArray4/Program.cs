var age = new int[]
{
12,
15,
25,
12,
56,
13,
81,
55,
25,
12,
};
Dictionary<int, int> list = new Dictionary<int, int>();
for  (int indexA = 0; indexA < age.Length; indexA++)
{
    if (list.ContainsKey(age[indexA]))
    {
        list[age[indexA]]++;
    }else
    {
        list[age[indexA]] = 1;
    }
}
foreach (var ages in age) 
{
    Console.WriteLine(age[IndexA]);
}