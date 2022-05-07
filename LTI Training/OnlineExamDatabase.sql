create database OnlineExam
use OnlineExam



create table Registration(User_id int identity(0,1) primary key,Fullname varchar(50),Email varchar(50) unique ,Password varchar(50),City varchar(50),DOB date,State varchar(50),
Qualification varchar(50),Year_of_Completion date,Mobile_no varchar(50));




create table Subject(Subject_id int primary key,Subject_name varchar(50) );






create table Level(Level_id int primary key, Level_Name varchar(100));




create table Exam(Exam_id int primary key,Questions nvarchar(255),Question_id int,
File_id int,Subject_id varchar(50));






create table ExamDetails(Duration time,Level_id int references level(Level_id),Cutoff int,Exam_id int references Exam(Exam_id) );




  drop table Filename
create table Filename(File_id int primary key, File_Name varchar(50));



drop table QuestionDetails
create table QuestionDetails(Question_id int primary key identity(0,1),QuestionNumber int , File_id int references Filename(File_id),Question nvarchar(255)
,Option1 varchar(255),Option2 varchar(255),Option3 varchar(255),Option4 varchar(255),Correctanswers varchar(255),Subject_id int references Subject(Subject_id),Level_id int references level(Level_id));



create table ReportDetails(User_id int references Registration(User_id),Level_id int references level(Level_id),
MarksObtained int, Subject_id int references Subject(Subject_id));




create table Admin_Login(Email varchar(50),Password varchar(50));





select * from Registration
select * from Subject
select * from ReportDetails
select * from Exam
select * from ExamDetails
select * from level
select * from QuestionDetails
select * from Filename
select * from AddQuestion




insert into Registration (Fullname,Email,Password,City,DOB,State,Qualification,Year_of_Completion,Mobile_no)
values('Rahul Tripathi ','rahul@gmail.com','rahul@123','Nashik','2000-06-13','Maharashtra','BE','2021',9876546792),
('Akshay Aher ','Akshay@gmail.com','akhay@123','A.Nagar','2000-05-16','Maharashtra','Bsc','2019',9966546792),
('Rameshwar Rothe','rameshwar@gmail.com','rameshwar@123','Mumbai','2000-06-17','Maharashtra','ME','2020',9876746792),
('Sam Rathod','sam@gmail.com','sam@123','Aurangabad','2000-06-15','Maharashtra','BE','2015',9860546792)




insert into Subject(Subject_id,Subject_name)values(1,'java'),(2,'c#.Net'),(3,'c++');


insert into ReportDetails(User_id,Level_id,MarksObtained,Subject_id) values(0,1,67,1),(1,1,70,3),(2,1,80,2);

create table AddQuestion(QuestionNumber int primary key, Question nvarchar(255)
,Option1 varchar(50),Option2 varchar(50),Option3 varchar(50),Option4 varchar(50),Correctanswer varchar(50));


select * from QuestionDetails

create table ForgotPassword(Email varchar(50) references Registration(Email),Emailsent BIT);

insert into Subject()




select * from Registration





alter table QuestionDetails alter column Option4 varchar(255) 




insert into level(Level_id,Level_Name)values(1,'Level_1'),(2,'Level_2'),(3,'Level_3')

insert into Subject(Subject_id,Subject_name)values(1,'java'),(2,'c#.Net'),(3,'C++'),(4,'SQL');

select * from Subject

insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(1,'In which memory a String is stored, when we create a string using new operator?','Stack','String memory','Heap memory',
'Random storage space','Heap memory',1,1),(2,' What is the use of the intern() method?','It returns the existing string from memory',
'It creates a new string in the database','It modifies the existing string in the database',
'None of the above','It returns the existing string from memory',1,1),(3,'Which of the following is a marker interface?','Runnable interface',
'Remote interface','Readable interface','Result interface','Remote interface',1,1),(4,'Which of the following is a reserved keyword in Java?','object'
,'strictfp','main','system','strictfp',1,1),(5,' Which keyword is used for accessing the features of a package?','package','import',
'extends','export','export',1,1)





insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(1,'An interface with no fields or methods is known as a ______.','Runnable Interface',
'Marker Interface','Abstract Interface','CharSequence Interface','Marker Interface',1,2)


insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(2,'Which of the following is an immediate subclass of the Panel class?','Applet class',
'Window class','Frame class','Dialog class','Applet class',1,2)

insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(3,'Which option is false about the final keyword?','final method cannot be overridden in its subclasses.',
'A final class cannot be extended.','A final class cannot extend other classes.','A final method can be inherited.','A final class cannot extend other classes.',1,2),
(4,'Which of these classes are the direct subclasses of the Throwable class?','RuntimeException and Error class',
'Exception and VirtualMachineError class','Error and Exception class','IOException and VirtualMachineError class','Error and Exception class',1,2),
(5,'What do you mean by chained exceptions in Java?',
'Exceptions occurred by the VirtualMachineError','An exception caused by other exceptions',
'Exceptions occur in chains with discarding the debugging information','None of the above','An exception caused by other exceptions',1,2)

insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(1,'Which of the following option leads to the portability and security of Java?','Bytecode is executed by JVM','The applet makes the Java code secure and portable','Use of exception handling','Dynamic binding between objects','Bytecode is executed by JVM',1,3),
(2,'Which of the following is not a Java features?','Dynamic','Architecture Neutral','Use of pointers','Object-oriented','Architecture Neutral',1,3),
(3,'The \u0021 article referred to as a','Unicode escape sequence','Octal escape','Hexadecimal','Line feed','Unicode escape sequence',1,3),
(4,'_____ is used to find and fix bugs in the Java programs.','JVM','JRE','JDK','JDB','JDB',1,3),
(5,'Which of the following is a valid declaration of a char?','char ch = \utea','char ca = tea;','char = \u0223;','char cc = \itea;','char ch = \utea',1,3)



select * from QuestionDetails


select * from Subject


insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(1,'Which of the following is correct about variable naming conventions in C#?',
'It should not be a C# keyword.',
'It must not contain any embedded space or symbol such as? - + ! @ # % ^ & * ( ) [ ] { }',
'Both of the above.','None of the above.','Both of the above.',2,1)

insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(2,' Which of the following is correct about Object Type in C#?',
'The Object Type is the ultimate base class for all data types in C# Common Type System (CTS).',
'Object is an alias for System.Object class.',
'The object types can be assigned values of any other types, value types, reference types, predefined or user-defined types.',
'All of the above.','All of the above.',2,1)







insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(3,'Which of the following converts a type to a 16-bit integer in C#?','ToDecimal','ToDouble','ToInt16','ToInt32','ToInt16',2,1),
(4,'Which of the following operator represents a conditional operation in C#?','?:','is','as','*','?:',2,1)



insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(5,'Which of the following statements is correct about access specifiers in C#?',
'Encapsulation is implemented by using access specifiers.','An access specifier defines the scope and visibility of a class member.','Both of the above.','None of the above.',
'An access specifier defines the scope and visibility of a class member.',2,1)



insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(1,'Which of the following is the correct about class constructor?',
'A class constructor is a special member function of a class that is executed whenever we create new objects of that class.',
'A constructor has exactly the same name as that of class and it does not have any return type.',
'Both of the above.','None of the above.','Both of the above.',2,2)


insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(2,'Operator overloading is a kind of dynamic polymorphism.','true','false','','','false',2,2),
(3,' Which of the following preprocessor directive allows to create a compound conditional directive, along with #if in C#?','define','elif','if','else','else',2,2)

insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(4,'Which of the following is true about exceptions in C#?',
'The exception classes in C# are mainly directly or indirectly derived from the System.Exception class.',
'C# exceptions are represented by classes.','Both of the above.','None of the above.','Both of the above.',2,2)



insert into QuestionDetails(QuestionNumber,Question,Option1,Option2,Option3,Option4,Correctanswers,Subject_id,Level_id)
values(5,'CLR is the .Net equivalent of _____.','Java Virtual machine','Common Language Runtime','Common Type System','Common Language Specification','Java Virtual machine',2,2)





select * from QuestionDetails

















A - The exception classes in C# are mainly directly or indirectly derived from the System.Exception class.



B - C# exceptions are represented by classes.



C - Both of the above.



D - None of the above.



C




1. CLR is the .Net equivalent of _____.
Java Virtual machine
Common Language Runtime
Common Type System
Common Language Specification
Ans: A




2. Abstract class contains _____.
Abstract methods
Non Abstract methods
Both
None
Ans: C



3. The default scope for the members of an interface is _____.
private
public
protected
internal
Ans: B
---------------level 3



4. Which of the following statements is incorrect about delegate?
Delegates are reference types.
Delegates are object-oriented.
Delegates are type-safe.
Only one can be called using a delegate.
Ans : D



5. The space required for structure variables is allocated on the stack.
True
False
Maybe
Can’t say
Ans: A




6. Which of the following is incorrect about constructors?
Defining of constructors can be implicit or explicit.
The calling of constructors is explicit.
Implicit constructors can be parameterized or parameterless.
Explicit constructors can be parameterized or parameterless.
Ans: C




7. Reference is a ___.
Copy of class which leads to memory allocation.
Copy of class that is not initialized.
Pre-defined data type.
Copy of class creating by an existing instance.
Ans: D



8. The data members of a class by default are?
protected, public
private, public
private
public
Ans: C



9. What is the value returned by function compareTo( ) if the invoking string is less than the string compared?
Zero
A value of less than zero
A value greater than zero
None of the mentioned
Ans: B



10. The correct way to overload +operator?
public sample operator + (sample a, sample b)
public abstract operator + (sample a, sample b)
public static operator + (sample a, sample b)
all of the mentioned above
Ans: D



11. Select the two types of threads mentioned in the concept of multithreading?
Foreground
Background
Only foreground
Both foreground and background
Ans: D



12. Choose the wrong statement about properties used in C#.Net?
Each property consists of accessor as getting and set.
A property cannot be either read or write-only.
Properties can be used to store and retrieve values to and from the data members of a class.
Properties are like actual methods that work like data members.
Ans: A



13. If a class ‘demo’ had ‘add’ property with getting and set accessors, then which of the following statements will work correctly?
math.add = 20;
math m = new math();
m.add = 10;
Console.WriteLine(math.add);
None of the mentioned
Ans: A

