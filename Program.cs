// インスタンス同値チェック
internal class Program
{
    private static void Main(string[] args)
    {
        Sample sample1 = new Sample();
        sample1.Name = "name";
        sample1.Age = 1;

        Sample sample2 = new Sample();
        sample2.Name = "name";
        sample2.Age = 1;
        // Sample sample2 = null;

        Console.WriteLine(sample1.Equals(sample2));
    }
}


public class Sample
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    // 同値チェック
    public override bool Equals(object? obj)
    {
        // すべてのフィールドの値が同じかチェック
        if (obj is Sample sample)
        {
            return
                this.Name == sample.Name &&
                this.Age == sample.Age;
        }
        return false;
    }
}