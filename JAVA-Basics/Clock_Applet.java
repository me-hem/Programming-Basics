import java.applet.Applet;
import java.awt.*;
import java.util.*;
/*	<applet code = "Clock_Applet" width = "200" height = "200" > </applet>	*/

public class Clock_Applet extends Applet implements Runnable
{
	Thread t, t1;
	public void start()
	{
		t = new Thread(this);
		t.start();
	}
	
	public void run()
	{
		t1 = Thread.currentThread();
		while(t == t1)
		{
			repaint();
			try
			{
				t1.sleep(1000);
			}
			catch(InterruptedException e){}
		}	
	}
	
	public void paint(Graphics g)
	{
		Calendar cal = new GregorianCalendar();
		
		String hour = String.valueOf(cal.get(Calendar.HOUR));
		String min = String.valueOf(cal.get(Calendar.MINUTE));
		String sec = String.valueOf(cal.get(Calendar.SECOND));
		
		g.drawString(hour+":"+min+":"+sec, 100,100);		
	}
}