//Xây dựng một ứng dụng chuyển đổi tiền tệ, cho phép tính giá trị tiền VNĐ dựa trên một tỉ giá cho trước và giá trị tiền USD được nhập vào.
//Khai báo biến tỉ giá (rate) để lưu giá trị tỉ giá giữa VND và USD. Hiện nay, tỉ giá có thể là 23000 VND/USD.
public class Program
{
    public static void Main(string[] args)
    {
        int rate = 23000;
        Console.WriteLine("Nhập số tiền USD cần chuyển đổi sang VND");
        int usd = Convert.ToInt32(Console.ReadLine());
        int vnd = usd * rate;
        Console.WriteLine($"số tiền VND sẽ là {vnd} vnđ"); 
    }
}
