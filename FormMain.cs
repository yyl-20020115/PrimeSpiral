namespace PrimeSpiral;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    public enum Directions : uint
    {
        Right = 0,
        Down = 1,
        Left = 2,
        Up = 3,
    }
    public static int DirectionsCount = Enum.GetValues(typeof(Directions)).Length;
    public static Point Step(Point p, Directions direction) => direction switch
    {
        Directions.Left => new Point(p.X - 1, p.Y + 0),
        Directions.Right => new Point(p.X + 1, p.Y + 0),
        Directions.Up => new Point(p.X + 0, p.Y - 1),
        Directions.Down => new Point(p.X + 0, p.Y + 1),
        _ => p,
    };
    public static Directions MakeTurn(Directions direction)
        => (Directions)(((uint)direction + 1) % DirectionsCount);
    public static int GetRatioPart(int r, int max, int range = 255)
        => (int)Math.Round((1.0 - r / (double)max) * range);

    public static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        for (long i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        int length = Math.Min(this.pictureBox.Width, this.pictureBox.Height);
        using var writer = new StreamWriter("Points.txt");
        var bitmap = new Bitmap(length, length);
        var op = new Point(bitmap.Width / 2, bitmap.Height / 2);
        var cp = op;
        int max_count = bitmap.Height * bitmap.Height;
        int points = 0;
        //Center Point First
        int r = 1;
        int max_r = Math.Max(bitmap.Width, bitmap.Height);
        int min_r = Math.Min(bitmap.Width, bitmap.Height);
        long n = 0;
        var direction = Directions.Up;
        int sum = 0;
        int vacancy = 0;
        do
        {
            int m = 0;
            for (int t = 0; t < 2; t++)
            {
                direction = MakeTurn(direction);
                for (int i = 0; i < r; i++)
                {
                    var prime = IsPrime(n);
                    var dp = new Point(cp.X - op.X,cp.Y-op.Y);
                    writer.WriteLine($"({cp.X},{cp.Y}),({dp.X},{dp.Y})={n},{(prime?1:0)}");
                    cp = Step(cp, direction);
                    n++;
                    m++;
                    if (cp.X >= 0 && cp.Y >= 0 && cp.X < bitmap.Width && cp.Y < bitmap.Height)
                    {
                        if (prime)
                        {
                            bitmap.SetPixel(cp.X, cp.Y, Color.Blue);
                        }
                        else
                        {
                            bitmap.SetPixel(cp.X, cp.Y, Color.FromArgb(
                                GetRatioPart(r, max_r),
                                GetRatioPart(r, max_r),
                                GetRatioPart(r, max_r)));
                        }
                    }
                    else
                    {
                        vacancy++;
                    }
                    points++;
                }
            }
            sum += m;
            writer.WriteLine($"r={r},m={m},sum={sum},points={points}");
            r++;

        } while (points < max_count);
        writer.WriteLine($"points:{points},vacancy={vacancy},max_s={max_r * max_r},min_s={min_r * min_r}");
        this.pictureBox.Image = bitmap;
    }
}
