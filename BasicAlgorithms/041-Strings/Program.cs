//ReadLn(a,b,c)
//10 20 30 
/*String s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] n=new int[ss.Length];
for(int i=0;i<ss.Length;i++)
    n[i]=Convert.ToInt32(ss[i]);
int a=n[0];
int b=n[2];
int c=n[3];
    */

String[] ss=Console.ReadLine().Split(' ');
int[] n=Array.ConvertAll<string,int>(ss,Convert.ToInt32);
int a=n[0];
int b=n[2];
int c=n[3];