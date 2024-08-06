class MyData<T>
{
	T var;
	public void add(T var)
	{	
		this.var = var;
	}
	
	public T get()
	{
		return(var);
	}
}

public class Generic_Class
{
	public static void main(String[] s)
	{
		MyData<Integer> obj1 = new MyData<Integer>();
		MyData<String> obj2 = new MyData<String>();
		Integer k = new Integer(53);
		
		obj1.add(k);
		obj2.add("Mr Hem");
		
		System.out.println("Name: "+obj2.get()+"\nRoll no': "+obj1.get());
	}
}