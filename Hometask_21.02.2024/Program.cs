
//var stu1 = new
//{
//    name = "Jack",
//    surname = "Scott",
//    age = 22
//};

//var stu2 = new
//{
//    name = "Kate",
//    surname = "Nilson",
//    age = 19
//};

//Console.WriteLine(stu1.name + " " + stu1.surname + " " + stu1.age);






//using Hometask_21._02._2024;

//Student stu1 = new Student();

//stu1.name = "Jack";
//stu1.surname = "Scott";
//stu1.age = 22;
//stu1.adress = "28 May";

//Console.WriteLine(stu1.name);





//Student stu2 = new();

//stu2.name = "test";
//stu2.surname = "test1";
//stu2.age = 23;
//stu2.adress = "test3";
//stu2.phone = "123435675";


//string fullName = stu2.name + " " + stu2.surname;

////Console.WriteLine(fullName);

//Student stu3 = new()
//{
//    name = "test1",
//    age = 12,
//    adress = "test3",
//};

//Console.WriteLine(stu3.phone);
//Console.WriteLine(stu3.surname);


//Console.WriteLine(stu1.GetFullName());

//Console.WriteLine(stu2.GetFullName());


//Console.WriteLine(stu1.GetFullDatas());




//Student[] students = {stu1,stu2, stu3};

//foreach (var student in students)
//{
//    Console.WriteLine(student.GetFullDatas());
//}


//void ShowAll(Student[] students)
//{
//    foreach(var student in students)
//    {
//        Console.WriteLine(student.GetFullDatas());
//    }
//}

//ShowAll(students);



//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{
//    Student foundStudent = new();

//    foreach(var student in datas)
//    {
//        if(student.age == age)
//        {
//            foundStudent = student;
//            break;
//        }
//    }
//    return foundStudent;
//}

//var result = GetByAge(students, 12);

//Console.WriteLine(result.name);





//Student GetByAge(Student[] datas, int age)
//{
//    var result = datas.FirstOrDefault(m => m.age == age);
//    return result != null ? result : new Student();
//}

//var result = GetByAge(students, 22);

//Console.WriteLine(result.GetFullDatas());



//int a = 6;

////Console.WriteLine(a == 5 ? a : "deyil");

//var result = a == 5 ? a.ToString() : "deyil";




//Student GetByAge(Student[] datas, int age)
//{
//    return datas.FirstOrDefault(m => m.age == age);
//}

//var result = GetByAge(students, 14);

//if(result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Data not found");
//}


//Student GetByAge(Student[] students, int age) => students.FirstOrDefault(m => m.age == age);
//var result = GetByAge(students, 14);

//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Data not found");
//}




//Book book = new Book();

//Console.WriteLine(book.name + " " + book.author);


