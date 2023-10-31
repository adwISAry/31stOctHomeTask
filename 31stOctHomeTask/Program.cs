using _31stOctHomeTask;

int id = 0, age = 0;
string fullname, groupNo;

do
{
    Console.Write("ID daxil edin: ");
    string idInput = Console.ReadLine();

    Console.Write("Ad və soyad daxil edin (format: Ad Soyad): ");
    fullname = Console.ReadLine();

    Console.Write("Qrup nömrəsini daxil edin (format: PXXX): ");
    groupNo = Console.ReadLine();

}
while (!Student.CheckGroupNo(groupNo) || !Student.CheckFullname(fullname) || id == 0 || age == 0);

Student student = new Student(id, fullname, groupNo, age);

Console.WriteLine("Tələblərə uyğun tələbə yaradıldı.");
Console.WriteLine($"ID: {student.Id}");
Console.WriteLine($"Ad və Soyad: {student.FullName}");
Console.WriteLine($"Qrup nömrəsi: {student.GroupNo}");
Console.WriteLine($"Yaş: {student.Age}");