using System;
using System.Collections;

// Used for file and directory
// manipulation
using System.IO;
using System.Text;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- THAO TÁC VỚI THƯ MỤC -----

            // Truy vấn vào thư mục hiện tại -> dữ liệu được lưu vào một đối tượng DirectoryInfo
            DirectoryInfo currDir = new DirectoryInfo(".");
            // Console.WriteLine(currDir.Exists);

            // // Truy vấn vào thư mục với đường dẫn đầy đủ
            // DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\Linh Ngo\Documents");

            // // Lấy đường dẫn thư mục đầy đủ
            // Console.WriteLine(myDir.FullName);

            // // Lấy tên thư mục
            // Console.WriteLine(myDir.Name);

            // // Lấy tên thư mục cha
            // Console.WriteLine(myDir.Parent);

            // // Dạng dữ liệu/ kiểu thư mục
            // Console.WriteLine(myDir.Attributes);

            // // Thư mục được tạo khi nào
            // Console.WriteLine(myDir.CreationTime);

            // Tạo mới thư mục
            // DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Linh Ngo\Documents\Test");
            // dataDir.Create();
            

            // Xóa thư mục
            // Directory.Delete(@"/home/linh/Desktop/CSharp/Data");


            
            // ----- ĐỌC VÀ VIẾT FILE ĐƠN GIẢN -----

            // Viết một mảng các chuỗi vào file text 
            string[] singers = {
                "Taylor Swift",
                "Adele",
                "Ed Sheeran"
            };
            // string[] singers2 = {
            //     "Taylor Swift2",
            //     "Adele2",
            //     "Ed Sheeran2"
            // };
            // string textFilePath = @"C:\Users\Linh Ngo\Documents\Test\testfile1.txt";;
            

            // Viết vào file
            // File.WriteAllLines (textFilePath, singers);
            // File.AppendAllText(textFilePath, "ABC");
            // // Đọc dữ liệu từ file
            // foreach (string item in File.ReadAllLines (textFilePath)) {
            //     Console.WriteLine ($"Singer : {item}");
            // }
            

            /* 
            // ----- LẤY DỮ LIỆU TỪ FILE -----

            DirectoryInfo myDataDir = new DirectoryInfo (@"/home/linh/Desktop/CSharp/Data");

            // Lấy tất cả dữ liệu của file với đuôi ".txt" và lưu vào mảng 
            FileInfo[] txtFiles = myDataDir.GetFiles ("*.txt", SearchOption.AllDirectories);

            // In ra thông tin các files
            Console.WriteLine ("Matches : {0}", txtFiles.Length);

            foreach (FileInfo file in txtFiles) {
                // Get file name
                Console.WriteLine (file.Name);
                // Get bytes in file
                Console.WriteLine (file.Length);
            }
            */

             /* 
            // ----- FILESTREAMS -----
            // FileStream dùng để đọc và viết 1 byte hoặc 1 mảng nhiều bytes

            string textFilePath2 = @"C:\Users\Linh Ngo\Documents\Test\testfile2.txt";

            // Tạo và mở file
            FileStream fs = File.Open (textFilePath2, FileMode.Create);

            string randString = "This is a random string";

            // Chuyển đổi chuỗi sang mảng chứa bytes
            byte[] rsByteArray = Encoding.Default.GetBytes (randString);

            // Viết vào file bằng cách truyền vào mảng dữ liệu dạng byte,
            // vị trí của byte bắt đầu viết và độ dài 
            fs.Write (rsByteArray, 0, rsByteArray.Length);

            // Di chuyển lại đầu file
            fs.Position = 0;

            // Tạo 1 mảng chứa bytes để lưu dữ liệu trong file
            byte[] fileByteArray = new byte[rsByteArray.Length];

            // Đọc byte trong fs và lưu vào mảng trên
            for (int i = 0; i < rsByteArray.Length; i++) {
                fileByteArray[i] = (byte) fs.ReadByte ();
            }

            // Chuyển đổi mảng bytes sang chuỗi và in ra console
            Console.WriteLine (Encoding.Default.GetString (fileByteArray));

            // Đóng FileStream
            fs.Close ();
            */

            
            // ----- STREAMWRITER / STREAMREADER -----
            // Cách tốt nhất để đọc và viết chuỗi

            string textFilePath3 = @"C:\Users\Linh Ngo\Downloads\GetMailFromScamText.txt";

            // // Tạo 1 file text - File class chứa các phương thức tĩnh hỗ trợ thao tác với file
            // StreamWriter sw = File.CreateText (textFilePath3);

            // // Viết vào file mà không xuống dòng
            // sw.Write ("This is a random ");

            // // Viết vào file rồi xuống dòng
            // sw.WriteLine ("sentence.");

            // // Viết một dòng nữa
            // sw.WriteLine ("This is another sentence.");

            // // Đóng StreamWriter
            // sw.Close ();

            // Mở file
            // StreamReader sr = File.OpenText (textFilePath3);

            // // Đọc 1 dòng
            // Console.WriteLine ("1st String : {0}", sr.ReadLine ());

            // // Đọc từ chỗ tiếp theo sau câu lệnh đọc trước cho đến cuối file
            // Console.WriteLine ("Everything : {0}", sr.ReadToEnd ());

            // // đóng streamreader đọc file
            // sr.Close ();
            ArrayList arr = new ArrayList();
            using(StreamReader sr = new StreamReader(textFilePath3)) {
                for (int i = 0; i < 10; i++)
                {
                    // arr.Add(sr.ReadLine());
                    Console.WriteLine (sr.ReadLine());  
                }
            }
           

            /*
            // ----- BINARYWRITER / BINARYREADER -----

            // Dùng để đọc và viết kiểu dữ liệu

            // file ".dat"
            string textFilePath4 = @"/home/linh/Desktop/CSharp/Data/testfile4.dat";

            // Lấy file
            FileInfo datFile = new FileInfo (textFilePath4);

            // Mở file
            BinaryWriter bw = new BinaryWriter (datFile.OpenWrite ());

            // Dữ liệu sẽ được ghi vào file
            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            // Viết dữ liệu vào file

            bw.Write (randText);
            bw.Write (myAge);
            bw.Write (height);

            // Đóng file 

            bw.Close ();

            // Mở file để đọc
             * 
            BinaryReader br = new BinaryReader (datFile.OpenRead ());

            // In ra console dữ liệu trong file

            Console.WriteLine (br.ReadString ());

            Console.WriteLine (br.ReadInt32 ());

            Console.WriteLine (br.ReadDouble ());

            br.Close ();

            */
        }
    }
}
