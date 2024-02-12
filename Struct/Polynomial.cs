struct Polynomial()
{
    public int N { get; set; }
    public Term[] term;

    public void Create()
    {
        int i;
        for (i = 0; i < N; i++)
        {
            System.Console.WriteLine("Term n° " + i + 1);
            term[i].Coefficient = int.Parse(Console.ReadLine());
            term[i].Exponent = int.Parse(Console.ReadLine());
        }
    }
    public void Display()
    {
        int i;
        for (i = 0; i < N; i++)
        {
            System.Console.Write(term[i].Coefficient);
            System.Console.Write("x");
            System.Console.Write(term[i].Exponent);
            System.Console.Write("+");
        }
    }
    public int Evaluate(int x)
    {
        int i, res = 0;
        for (i = 0; i < N; i++)
        {
            res = term[i].Coefficient * Pow(x, term[i].Exponent);
        }
        return res;
    }
    public int Pow(int x, int term)
    {
        return 0;
    }

    public Polynomial Addition(Polynomial p1, Polynomial p2)
    {
        int i = 0, j = 0, k = 0;
        int N = p1.N + p2.N;
        Polynomial p3 = new()
        {
            N = N,
            term = new Term[N]

        };
        while (i < p1.N && j < p2.N)
        {
            if (p1.term[i].Exponent > p2.term[j].Exponent)
            {
                p3.term[k++] = p1.term[i++];
            }
            else if (p1.term[i].Exponent < p2.term[j].Exponent)
            {
                p3.term[k++] = p2.term[j++];
            }
            else
            {
                p3.term[k].Exponent = p2.term[j].Exponent;// p1.term[i].Exponent because is the same
                p3.term[k++].Coefficient = p2.term[j++].Coefficient + p1.term[i++].Coefficient;
            }
        }
        for (; i < p1.N; i++) p3.term[k++] = p1.term[i];
        for (; j < p2.N; j++) p3.term[k++] = p2.term[j];
        return p3;
    }
}