import java.applet.Applet;
import java.awt.event.*;
import java.awt.*;
/*	<applet code = "Calc_Applet" width = "300" height = "300"> </applet>	*/

public class Calc_Applet extends Applet
{
	Label l1, l2, l3, l4, l5;
	TextField t1, t2, t3;
	Button b;
		
	public void init()
	{
		l1 = new Label("Simple Calculator");
		l2 = new Label("First Number");
		l3 = new Label("Second Number");
		l4 = new Label("Operator");
		l5 = new Label();
		t1 = new TextField();
		t2 = new TextField();
		t3 = new TextField();
		b = new Button("Add");
		
		setLayout(null);
		
		l1.setBounds(100,20,100,20);
		l2.setBounds(30,50,100,20);
		l3.setBounds(30,100,100,20);
		l4.setBounds(30,150,100,20);
		l5.setBounds(100,250,150,20);
		t1.setBounds(140,50,100,20);
		t2.setBounds(140,100,100,20);
		t3.setBounds(140,150,100,20);
		b.setBounds(100,220,80,20);
		
		add(l1);
		add(l2);
		add(t1);
		add(l3);
		add(t2);
		add(l4);
		add(t3);
		add(l5);
		add(b);
		
		b.addActionListener(new Handler());
	}
	
	public class Handler implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
		{
			int a,b;
			String ch;
			a = Integer.parseInt(t1.getText());
			b = Integer.parseInt(t2.getText());
			ch = t3.getText();
			
			switch(ch)
			{
				case "+":
					l5.setText(a+" + "+b+" = "+(a+b));
					break;
				case "-":
					l5.setText(a+" - "+b+" = "+(a-b));
					break;
				case "*":
					l5.setText(a+" * "+b+" = "+(a*b));
					break;
				case "/":
					if(b == 0)
						l5.setText(a+" / "+b+" = "+"not defined");
					else
						l5.setText(a+" / "+b+" = "+(a/b));
					break;
				case "%":
					if(b == 0)
						l5.setText(a+" % "+b+" = "+"not defined");
					else
						l5.setText(a+" % "+b+" = "+(a%b));
					break;
			}		
		}
	}
}
