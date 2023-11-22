namespace factory_method
{
    public interface Isanphamkem
    {
        void loaikem();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // tao doi tuong nha may cua lop nhamaykem
            nhamaykem nhamay = new nhamaykem();
            /* Gọi Createsanphamkem method của đối tượng nhamay với các giá trị "kem dau",
             "kem vani", và "kem dua hau" để tạo các đối tượng kem tương ứng.*/
            Isanphamkem kemloai1 = nhamay.Createsanphamkem("kem dau");
            Isanphamkem kemloai2 = nhamay.Createsanphamkem("kem vani");
            Isanphamkem kemloai3 = nhamay.Createsanphamkem("kem dua hau");
            kemloai1.loaikem();
            kemloai2.loaikem();
            kemloai3.loaikem();
            Console.ReadLine();
           
        }
    }
}