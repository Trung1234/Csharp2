CSharp-Materials

CSharp - Nội dung chương trình

Thời gian: 1 tháng thực tập toàn thời gian bao gồm 12 buổi seminar. Mỗi seminar 3 tiếng. Tuần 3 buổi 2, 4, 6 từ 9h đến 12h.
Lý thuyết: cú pháp học viên xem video online + làm quiz + tự đọc tài liệu và ví dụ tham khảo
Seminar: Mỗi tuần 2 buổi giảng viên hướng dẫn bổ sung kiến thức và thực hành. Một buổi thứ 6 học viên sẽ lần lượt trình bày một chủ đề, yêu cầu học viên rèn luyện tinh thần chủ động nghiên cứu và tổng hợp kiến thức.
Hình thức kiểm tra:
Cuối mỗi tuần sẽ có 1 bài quiz + thực hành trên lớp (4 tests - 80%)
Xuyên suốt 1 tháng sẽ giải 60 bài tập nhỏ (12 seminar * 5 bài) - cần hoàn thành ít nhất 70% số lượng, 40 bài (20%)
==============================================

Nội Dung Đào Tạo:

Tuần 1: using VSCode, basic C#, coding conventions, variables, data types, type conversion, exception handling, console methods, manipulating string, arrays,handling logic, control flow
Tuần 2: struct, enum, collections, generic type, LINQ, file i/o
Tuần 3: OOP & unit testing
Tuần 4: Delegates & Events, regular expression, ADO.NET
==============================================

Buổi 1:

Chủ đề: khai báo biến, kiểu dữ liệu, nhận console input, try catch
Bài tập:

Simple Calculator: Nhập 2 số và in ra kết quả cộng trừ nhân chia
Swapping numbers: Nhập 2 số, lưu vào 2 biến và hoán đổi giá trị của 2 biến này
Display Info: Hiển thị thông tin học sinh. Nhận tên, mã sinh viên, tuổi, lớp, tên trường từ console và lưu vào biến thích hợp sau đó in ra console
Binary Converter: Nhận 1 số và in ra số đó dạng nhị phân
Count Vowels: nhập vào 1 chuỗi và đếm xem có bao nhiêu nguyên âm trong chuỗi cũng như số lượng của từng nguyên âm
Buổi 2:

Chủ đề: chuỗi, mảng, điều kiện, vòng lặp
Bài tập:

Reverse String: Nhận 1 chuỗi và in ra chuỗi đảo ngược các kí tự cách nhau bằng dấu "-"
Length Counter: Tìm chiều dài của một chuỗi mà không dùng thuộc tính ".Length" có sẵn
Draw: Vẽ hình tam giác vuông trên console -> nâng cấp dùng while để vẽ nhiều hình
Palindrome: Nhập 1 chuỗi và kiểm tra xem chuỗi đảo ngược của nó và nó có giống nhau không, ví dụ "eye".
FizzBuzz: Chương trình in ra số từ 1 đến 100, nếu chi hết cho 3 thì in ra Fizz, chia hết cho 5 thì in ra Buzz và chia hêt cả 3 và 5 thì in ra FizzBuzz thay vì số đó.
Buổi 3:

Chủ đề: thuật toán cơ bản
Bài tập:

Prime Number: Kiểm tra 1 số có phải số nguyên tố không
Fibonacci: In dãy fibonacci
Tìm số fibonacci thứ n
Tìm bội số chung nhỏ nhất (LCM)
Tìm ước số chung lớn nhất (GCD)
Buổi 4:

Chủ đề: file i/o
Bài tập:

Tạo 1 thư mục mới
Tạo 1 file text mới và viết dữ liệu vào
Tìm tất cả file trong 1 thư mục
Hangman game: đọc dữ liệu từ 1 file text chứa các từ khóa, chọn 1 từ ngẫu nhiên trong file này và viết game đoán chữ trên console
Buổi 5:

Chủ đề: generics, collection, linq
Bài tập:

Nhận phần tử của 1 tập hợp List qua console và in ra những số chẵn
Có 1 tập hợp chuỗi, tìm phần tử bắt đầu và kết thúc với kí tự nhất định
Nhận tập hợp List chứa số và in ra n-th số lớn nhất
Tạo 1 tập hợp chuỗi và sắp xếp các phần tử riêng biệt theo thứ tự A-Z
Tính trung bình kích thước các file trong 1 thư mục bằng linq
Cho 1 tập hợp học sinh và điểm, tìm các học sinh có điểm thấp hơn điểm trung bình sử dụng let trong linq
Buổi 6:

Chủ đề: enum, struct, nullable, class, object
Bài tập:

Viết chương trình lưu các ngày trong tuần bằng enum và in ra giá trị của enum cũng như giá trị số tương ứng.
Tạo Book Class có các thuộc tính như bookID, title, author, year,...giả lập ta có CSDL BookStore trong đó có 1 List lưu nhiều sách, dùng linq tạo chức năng tìm kiếm sách theo tiêu đề, lọc theo tác giả, lọc theo chủ đề, năm,...
Ví dụ đặt tên CSDL là class BookStore trong đó có 1 List lưu nhiều sách, class này có phương thức FindByTitle, FindByAuthor, FindByYear, FindByID,....Người dùng chỉ có quyền truy vấn dữ liệu qua các phương thức public chứ không được trực tiếp trỏ vào hay thay đổi dữ liệu List trong BookStore.
Buổi 7:

Chủ đề: oop: abstraction, encapsulation & inheritance, object initialiser
Bài tập:

Tạo 1 chương trình quản lý ô tô: dựng 1 class Car có các thuộc tính phù hợp (Color, Year, Brand, Mileage,...). Trong class Car cần khởi tạo các constructors khác nhau nhận tham số đầu vào khi khởi tạo đối tượng khác nhau. Ngoài ra, tạo biến và phương thức static để có thể kiểm tra số lượng đối tượng ô tô được tạo ra. Ví dụ sau khi có class Car, trong hàm Main ta có thể gọi các câu lệnh dưới đây và in ra kết quả đúng.
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2008);

            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
Tạo 1 base class Person, các lớp con Student, Teacher,... kế thừa từ nó. Lớp Person có 1 số đặc tính chung, còn mỗi lớp con sẽ có 1 số thuộc tính hay phương thức riêng biệt của nó.
Tạo và sử dụng static Calculator class có các phương thức Add, Substract, Multiply, Divide,...
Nâng cao class Person với nhiều constructor, lớp con sử dụng lại base contructors, gợi ý từ khóa public Student () : base () {...}
Buổi 8:

Chủ đề: oop - polymorphism, interface
Bài tập:

Static polymorphism hay method overloading: nâng cấp static class Calculator với nhiều phiên bản của các phương thức trong nó. Ví dụ, Add(3, 3) nhận 2 số dạng int còn Add(10.05, 11.33) nhận 2 số double,...

Dynamic polymorphism hay method overriding: sử dụng abstract hay virtual method ở lớp cha và lớp con override - tạo base class là Shape và lớp con Circle, Rectangle,...có phương thức getArea, getPerimeter,...Mỗi lớp có thuộc tính phù hợp và cách thực thi phương thức getArea, getPerimeter khác nhau.

Tạo nhiều class và thực thi interface chung theo ví dụ trong videos: class smartphone có lớp con IPhone, Samsung sẽ thực thi 1 interface nào đó. Chi tiết các phương thức và interface các bạn tự dựng.

Product Inventory: tạo ưng dụng quản lý sản phẩm, lớp Product gồm thông tin tên, số lượng, giá,...; lớp Inventory quản lý nhiều sản phẩm, thay đổi sản phẩm, thể hiện giá trị thông tin sản phẩm,....Khi khởi tạo lớp Product ta tạo 1 loại sản phẩm, ví dụ, apple. Nhưng khi khởi tạo 1 Inventory, nó có thể chứa nhiều loại sản phẩm, ví dụ inventory1.Items = new List<Product>(){apple, banana, watermelon};. Tự nghĩ phần xử lý logic của các phương thức hợp lý. Ví dụ, AddProduct() thêm sản phẩm vào trong 1 inventory. Lớp Inventory quản lý có phương thức IncreaseQuantity(apple, 2) thì tăng số lượng của apple 2 đơn vị, tương tự các phương thức DecreaseQuantity(), IncreasePrice(),...Phần thực thi của các phương thức nên kiểm tra xem sản phẩm có tồn tại hay không, nếu không tồn tại thì yêu cầu gọi AddProduct() để thêm vào trước.

Bank Account Manager: Account base class với derived classes: SavingAccount, CheckingAccount, InvestmentAccount. Các bạn tự thiết kế thuộc tính, phương thức hợp lý theo ý mình.

Buổi 9:

Chủ đề: unit testing
Bài tập:

Quadratic function: giải phương trình bậc hai và viết unit test hàm này. Kiểm thử các trường hợp inputs khác nhau.
Viết unit test cho ứng dụng Bank Account Manager và Product Inventory. Ví dụ trong Product Inventory, có thể viết các tests kiểm tra khởi tạo đối tượng Product có đúng không? Cập nhật các thuộc tính có đúng không? Thêm sản phầm vào Inventory thì số lượng danh sách sản phẩm có đúng không? Kiểm thử các hàm IncreaseQuantity(), IncreasePrice(),....
Buổi 10:

Chủ đề: ADO.NET, connected mode, connection, SQL command
Bài tập:

Tạo ứng dụng console kết nối với MS SQL Server
Chạy câu lệnh SQL cơ bản trong ứng dụng C#
Buổi 11:

Chủ đề: Delegates & events
Bài tập:

Tạo các hàm tính toán đơn gian dùng delegates
Buổi 12:
