public class Generic_Method
{
	public <E> void print_arr(E[] e)
	{
		for(E item: e)
			System.out.println(item);
	}
	
	public static void main(String[] s)
	{
		Generic_Method g = new Generic_Method();
		String str[] = new String[]{"hem","umesh","me"};
		Integer i[] = {1,2,1,2,1,32,33};
		g.print_arr(str);
		g.print_arr(i);
	}
}