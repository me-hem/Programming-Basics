public class Initialize
{
	private static int stat;
	private int normal;

	{
		System.out.println("Initialization block Normal: "+normal);
		normal+=5;
	}

	static
	{
		System.out.println("Static block Stat: "+stat);
		stat+=5;
	}

	public Initialize()
	{
		System.out.println("Constructor Normal: "+normal);
		System.out.println("Constructor Stat: "+stat);
	}

	public static void main(String args[])
	{
		Initialize I1 = new Initialize();
		Initialize I2 = new Initialize();
		new Initialize();		
	}
}