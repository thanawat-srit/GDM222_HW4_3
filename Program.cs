
class Program
{
    static void Main(string[] args)
    {
        int nNode = int.Parse(Console.ReadLine());
        Graph g = new Graph(nNode);
        List<int> intLists = new List<int>();

        while(true){
            bool srcCheck = true;
            bool dstCheck = true;

            int src = int.Parse(Console.ReadLine());
            if(src < 0){
                break;
            }
            foreach (int node in intLists){
                if(node == src){
                    srcCheck = false;
                    break;
                }
            }
            if(srcCheck){
                intLists.Add(src);
            }
            if(intLists.Count > nNode){
                break;
            }

            int dst = int.Parse(Console.ReadLine());
            if(dst < 0){
                break;
            }
            foreach (int node in intLists){
                if(node == dst){
                    dstCheck = false;
                    break;
                }
            }
            if(dstCheck){
                intLists.Add(dst);
            }
            if(intLists.Count > nNode){
                break;
            }

            g.AddEdge(src, dst);
        }

        if (g.IsReachable(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())))
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
    }
}