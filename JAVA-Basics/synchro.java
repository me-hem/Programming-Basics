import java.util.Scanner;

class Account
{
	private int bal;

	public Account(int bal)
	{ this.bal = bal;}
	
	public boolean isSufficientBal(int amt)
	{
	    if(bal >= amt)
		return true;
	    else
		return false;
	}

	public void withdraw(int amt)
	{
		bal-=amt;
		System.out.println("Withdrawl amount: "+amt);
		System.out.println("Current balance: "+bal);
	}
}

class Customer implements Runnable
{ 	
	private Account account;
	private String name;
	public Customer(Account account, String name)
	{
		this.account = account;
		this.name = name;
	}
	
 	public void run()
	{
		Scanner sc = new Scanner(System.in);
		synchronized(account)
		{
			System.out.println(name+", enter amount to withdraw: ");
			int amt = sc.nextInt();
	
			if(account.isSufficientBal(amt))
				account.withdraw(amt);
			else	
				System.out.println("Insufficient balance");	
		}
		
	}

}



public class synchro
{
	public static void main(String args[])
	{
		Account account = new Account(1000);
		Customer C1 = new Customer(account,"Hem"), C2 = new Customer(account,"Umesh");
		Thread t1 = new Thread(C1);
		Thread t2 = new Thread(C2);

		t1.start();
		t2.start();
	}
}