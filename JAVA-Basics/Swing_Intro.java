import javax.swing.*;

public class Swing_Intro extends JFrame
{
	public Swing_Intro(String str)
	{
		super(str);
	}
	public static void main(String[] args) 
	{	
		//JFrame jf  = new JFrame("Swing_Intro");
		Swing_Intro jf = new Swing_Intro("Swing_Intro");
		jf.setSize(300,300);
		jf.setVisible(true);
		jf.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
	}
}