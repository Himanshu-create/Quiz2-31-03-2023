
namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(sol("5F3Z-2e-9-w", 4));
            Console.WriteLine(sol("2-5g-3-J", 2));
            Console.WriteLine(sol("2-4A0r7-4k", 3));
            Console.WriteLine(sol("nlj-206-fv", 3));

            //Console.WriteLine(License("Eric", 2, "Adam Caroline Rebecca Frank"));
            //Console.WriteLine(License("Zebediah", 1, "Bob Jim Becky Pat"));
            //Console.WriteLine(License("Aaron", 3, "Jane Max Olivia Sam"));

        }

        public static String sol(String s, int n)
        {
            String[] list = s.Split("-");
            String ss = "";
            foreach(String s2 in list) {
                ss += s2;
            }
            int l = ss.Length;

            String ans = "";
            int k = 0;
            for(int i = l - 1; i >= 0; i-= 1)
            {
                ans = ss[i] + ans;
                k++;
                if(k == n && i != 0)
                {
                    k = 0;
                    ans = "-" + ans;
                }
            }
            return ans.ToUpper();

        }

        public static int License(string name, int agent, string names)
        {
            int ans = 20;
            List<string> li = new();
            string[] namesArr = names.Split();
            li.Add(name);
            foreach (string s in namesArr)
            {
                li.Add(s);
            }
            li.Sort();

            int k = 0;
            foreach (string s in li)
            {

                if (s == name)
                {
                    break;
                }
                k += 1;
                if (k == agent)
                {
                    ans += 20;
                    k = 0;
                }

            }
            return ans;
        }


    }
}