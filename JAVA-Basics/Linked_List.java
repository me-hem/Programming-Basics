import java.util.*;

public class Linked_List
{
	public static void main(String[] s)
	{
		LinkedList list = new LinkedList();
		list.addFirst("Me");
		list.addLast("Hem");
		list.add(1,"Mr");
		System.out.println(list.getFirst());
		System.out.println(list.get(1));
		System.out.println(list.getLast());
	}
	
}