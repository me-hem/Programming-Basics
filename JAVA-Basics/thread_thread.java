class A extends Thread
{
	public void run()
	{
		int i;
		for(i=0;i<11;++i)
			System.out.println("Thread A: "+i);
	}
}

class B extends Thread
{
	public void run()
	{
		int i;
		for(i=0;i<11;++i)
			System.out.println("Thread B: "+i);
	}
}

public class thread_thread
{
	public static void main(String[] s)
	{
		A t1 = new A();
		B t2 = new B();
		t1.start();
		t2.start();
	}
}