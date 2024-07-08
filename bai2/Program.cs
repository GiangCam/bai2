using bai2;
List<phimvideo> movielist = new List<phimvideo>();
while (true)
{
    Console.WriteLine("\n===== Quan ly phim VIDEO =====");
    Console.WriteLine("phimmoi. Ten bo phim moi");
    Console.WriteLine("danh sach. Hien thi danh sach ");
    Console.WriteLine("next.thoat");
    Console.Write("Vui long chon phimmoi/danh/next");
    string choice = Console.ReadLine(); 
    switch (choice)
    {
        case "phimmoi":
            Console.WriteLine("\nNhap thong tin cho bo phim moi:");
            Console.Write ("tTen bo phim: ");
            string ten = Console.ReadLine();
            Console.Write("The loai");
            string theloai = Console.ReadLine();
            Console.Write("tTen bo phim: ");
            string Daovien = Console.ReadLine();
            Console.Write("Dao vien");
            string daovien = Console.ReadLine();
            Console.Write("dvnam");
            string dvnam = Console.ReadLine();
            Console.Write("hang san xuat: ");
            string hsx = Console.ReadLine();
            Console.Write("Ten dvnu: ");
            string dvnu = Console.ReadLine();
            Console.Write("nam san xuat: ");
            string nsx = Console.ReadLine();

            phimvideo movie = new phimvideo(ten, theloai, daovien, dvnam, dvnu,nsx, hsx);
            movielist.Add(movie);
            Console.WriteLine("\n Da them bo phoim moi vao danh sach.");
            break;
        case "danh sach":
            Console.WriteLine("\n danh sach cac bo phim:");
            foreach (var mv in movielist)
            {
                mv.Hienthiphimvideo();
            }
            break;

        case "next":
            Console.WriteLine("\n Da thoat chuong trinh.");
            return;
         
        default:
            Console.WriteLine("\n Lua chon khong hop le. vui long chon lai.");
            break;
    }    
}
