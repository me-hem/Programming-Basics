import java.io.*;
public class read_file
{
	public static void main(String[] s) throws IOException
	{
		FileInputStream fin = new FileInputStream("./newfile.txt");
		int i ;
		while((i = fin.read())!=-1)
		{
			System.out.print((char)i);
		}
		fin.close();
	}
	
}