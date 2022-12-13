char c='a';
c='\x0064';
c='\u0054';
char b='a';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString());
if (b>='0' && b<='9') System.Console.WriteLine("It's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit");

string s="asdf";
//immutable string(не изменяемые строки)
System.Console.WriteLine(s[0]);
for(int i=0;i<s.Length;i++)
    System.Console.WriteLine(s[i]);
//s[0]='S';
Char[] cc=s.ToCharArray();
cc[0]='S';
s=new String(cc);

