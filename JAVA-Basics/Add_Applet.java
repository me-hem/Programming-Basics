import java.applet.Applet;
import java.awt.event.*;
import java.awt.*;

/*<applet code = "Add_Applet" width = "300" height = "250"> </applet>*/

public class Add_Applet extends Applet
{
	Label l1, l2, l3;
	TextField t1, t2;
	Button b;
	
	public void init()
	{
		l1 = new Label("First number:");
		l2 = new Label("Second number:");
		l3 = new Label();
		t1 = new TextField();
		t2 = new TextField();
		b = new Button("Add");
		
		setLayout(null);
		
		l1.setBounds(30,50,100,20);
		l2.setBounds(30,100,100,20);
		l3.setBounds(100,200,100,20);
		t1.setBounds(140,50,100,20);
		t2.setBounds(140,100,100,20);
		b.setBounds(110,160,60,20);
		
		add(l1);
		add(t1);
		add(l2);
		add(t2);
		add(b);
		add(l3);
		b.addActionListener(new MyHandler());
	}
	
	public class MyHandler implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
		{
			int a, b;
			a = Integer.parseInt(t1.getText());
			b = Integer.parseInt(t2.getText());
			l3.setText(a+" + "+b+" = "+(a+b)); 
		}
	}
}