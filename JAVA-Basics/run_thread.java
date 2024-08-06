class A implements Runnable
{
	public void run()
	{
		int i;
		for(i=0;i<11;++i)
			System.out.println("Thread A: "+i);
	}
}

class B implements Runnable
{
	public void run()
	{
		int i;
		for(i=0;i<11;++i)
			System.out.println("Thread B: "+i);
	}
}

public class run_thread
{
	public static void main(String[] s)
	{
		Thread t1 = new Thread(new A());
		Thread t2 = new Thread(new B());
		t1.start();
		t2.start();
	}
}