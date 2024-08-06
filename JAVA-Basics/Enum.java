import java.util.*;

public class Enum
{
	public static void main(String[] args)
	{
		Vector v = new Vector();
		v.addElement("Hem");
		v.addElement("Umesh");
		v.addElement("Sunny");
		v.addElement("Kunal");
		
		System.out.println(v);
		
		Enumeration e = v.elements();
		while(e.hasMoreElements())
		{
			String s = (String)e.nextElement();
			System.out.println(s+": "+s.length());
		}
	}
}