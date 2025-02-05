import javax.swing.*;
import java.awt.event.*;
public class Add_Swing extends JFrame
{
	JLabel l1, l2, l3, l4;
	JTextField t1, t2;
	JButton b;
	
	public Add_Swing(String str)
	{
		super(str);
	}
	
	public void setComponents()
	{
		l1 = new JLabel("Addition of two numbers.");
		l2 = new JLabel("First Number");
		l3 = new JLabel("Second Number");
		l4 = new JLabel();
		t1 = new JTextField();
		t2 = new JTextField();
		b = new JButton("Add");
		
		setLayout(null);
		l1.setBounds(50,20,200,20);
		l2.setBounds(30,70,100,20);
		l3.setBounds(30,120,100,20);
		l4.setBounds(80,200,100,20);
		t1.setBounds(140,70,100,20);
		t2.setBounds(140,120,100,20);
		b.setBounds(80,170,80,20);
		
		add(l1);
		add(l2);
		add(t1);
		add(l3);
		add(t2);
		add(b);
		add(l4);
		
		b.addActionListener(new Handler());
		
	}
	
	public class Handler implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
		{
			int a, b;
			a = Integer.parseInt(t1.getText());
			b = Integer.parseInt(t2.getText());
			
			l4.setText(a+" + "+b+" = "+(a+b));
		}
	}
	
	public static void main(String[] s)
	{
		Add_Swing obj = new Add_Swing("Addition");
		
		obj.setComponents();
		obj.setSize(300,300);
		obj.setVisible(true);
		obj.setDefaultCloseOperation(obj.EXIT_ON_CLOSE);
	}
}	