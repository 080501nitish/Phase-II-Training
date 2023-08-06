using SimpleProg;

/*StudentGrade studentGrade = new StudentGrade(121, "Varun", "Sulur", 99, 99, 99);
Console.WriteLine(studentGrade.Rno);
Console.WriteLine(studentGrade.Name);
Console.WriteLine(studentGrade.Address);
Console.WriteLine("Total Marks " + " " + studentGrade.CalculateTotal());
Console.WriteLine("Average Marks " + " " + studentGrade.CalculateAverage());
Console.WriteLine("Grade " + " "+  studentGrade.CalculateGrade());*/
TeachingStaff teachingStaff = new("SREC","NGGO Colony",102, "Parithi", "Pollachi","BCA", 11000, 40, 25, 10, 5);
NonTeachingStaff nonTeachingStaff = new("SREC","NGGO Colony",102, "Varun", "Sulur", 11000, 40, 25, 10, 5);
StaticDemo student = new("SREC", "NGGO Colony", 11, "Sriram", "PNP");
College college = new("SREC", "NGGO Colony");
Console.WriteLine("Teaching Staff \n");
Console.WriteLine(teachingStaff.CollegeName);
Console.WriteLine(teachingStaff.Collegeaddress);
Console.WriteLine(teachingStaff.Name);
Console.WriteLine(teachingStaff.Dept);
Console.WriteLine(teachingStaff.Basicsalary);
Console.WriteLine(teachingStaff.CalculateSalary());
Console.WriteLine();
Console.WriteLine("Non Teaching Staff \n");
Console.WriteLine(nonTeachingStaff.CollegeName);
Console.WriteLine(nonTeachingStaff.Collegeaddress);
Console.WriteLine(nonTeachingStaff.Name);
Console.WriteLine(nonTeachingStaff.Basicsalary);
Console.WriteLine(nonTeachingStaff.CalculateSalary());
Console.WriteLine();
Console.WriteLine("Student Details \n");
student.DisplayCollegeDetails();
Console.WriteLine(student.Name);
Console.WriteLine(student.Rno);
Console.WriteLine(student.Address);
Console.WriteLine();
Console.WriteLine("College Details \n");
college.DisplayCollegeDetails();



