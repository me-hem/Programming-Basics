import java.util.*;

public class Iter
{
	public static void main(String[] args)
	{
		ArrayList arr = new ArrayList();
		for(int i=0;i<10;++i)
			arr.add(i);
		System.out.println(arr);

		Iterator iter = arr.iterator();
		while(iter.hasNext())
		{
			Integer I = (Integer)iter.next();
			if(I>3 && I<8)
				iter.remove();
		}
		System.out.println(arr);
		
	}
}