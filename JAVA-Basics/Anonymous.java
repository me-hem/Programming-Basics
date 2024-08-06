class Greeting
{
	public void say()
	{
		System.out.println("Hello");
	}
}

class India
{
	Greeting g = new Greeting()
	{
		public void say()
		{
			System.out.println("namaste");
		}
	};
}

public class Anonymous
{
	public static void main(String[] s)
	{
		India obj = new India();
		obj.g.say();
	}
}