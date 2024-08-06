import java.util.*;

public class Array_List
{
	public static void main(String []s)
	{
		ArrayList arr = new ArrayList(4);
		arr.add("Hem");
		arr.add("Umesh");
		
		Iterator iter = arr.iterator();
		
		while(iter.hasNext())
		{
			System.out.println(iter.next());
		}
	}
}