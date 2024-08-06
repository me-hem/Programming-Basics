package example;
import student.Student;

public class Example
{
	public static void main(String s[])
	{
		Student s1 = new Student();
		s1.setRoll(53);
		s1.setName("Hem");
		System.out.println("Name: "+s1.getName()+"\nRoll no': "+s1.getRoll());
	}	
	
}