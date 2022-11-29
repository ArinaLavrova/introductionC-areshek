//Списки

List<int> t;
t=new List<int>(1000);
for(int i=0;i<7;i++)
    t.Add(Convert.ToInt32(Console.ReadLine()));
double s=0;
for(int i=0;i<7;i++)
    s=s+t[i];
    System.Console.WriteLine(s/t.Count);
