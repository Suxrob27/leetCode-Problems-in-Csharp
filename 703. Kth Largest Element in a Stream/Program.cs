public class KthLargest
{
   public PriorityQueue<int, int> pq;
    int kth = 0;

    public KthLargest(int k, int[] nums)
    {
        pq = new PriorityQueue<int, int>();
        kth = k;
        foreach (int i in nums)
        {
            Add(i);
        }
    }

    public int Add(int val)
    {
        pq.Enqueue(val, val);
        while (pq.Count > kth)
        {
            pq.Dequeue();
        }
        return pq.Peek();
    }
}

class Program
{
     static void  Main(string[] args)
     {
        KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]); 
        kthLargest.Add(3);   // return 4
        kthLargest.Add(5);   // return 5
        kthLargest.Add(10);  // return 5
        kthLargest.Add(9);   // return 8
        kthLargest.Add(4);   // return 8
        for (int i = 0; i < kthLargest.pq.Count; i++)
        {
            Console.WriteLine(kthLargest.pq.Dequeue());
        }
    }
}
