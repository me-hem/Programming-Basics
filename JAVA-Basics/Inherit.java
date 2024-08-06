//Program to implement inheritance
import java.util.*;
class base
{	
	int base = 11;
	public void show()
	{
		System.out.println(base);
	}	
}

class child extends base
{
	public void display()
	{ 	
		System.out.println("Inheritance Implemented Successfully");
	}
}

class Inherit
{ 	
	public static void main(String s[])
	{	child obj = new child();
		obj.display();
		obj.show();
	}
}