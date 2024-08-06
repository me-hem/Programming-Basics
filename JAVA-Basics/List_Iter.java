import java.util.*;
public class List_Iter
{
	public static void main(String[] agrs)
	{
		LinkedList list = new LinkedList();
		list.add("C");
		list.add("C++");
		list.add("JAVA");
		list.add("PHP");
		System.out.println(list);
		ListIterator liter = list.listIterator();
		
		while(liter.hasNext())
		{ 	
			String s = (String)liter.next();
			if(s == "C")
				liter.set("Modified C");
		}
		
		System.out.println(list);
	}
}