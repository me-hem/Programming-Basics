import java.io.*;

public class read_buffer
{
	public static void main(String[] s) throws IOException
	{
		BufferedReader file  = new BufferedReader(new FileReader("./newfile.txt"));
		/*int i;
		while((i = file.read()) != -1)
			System.out.print((char)i);*/
		
		/*
		char s[] = new char[20];
		file.read(s,0,10);
		System.out.print(s);
		*/
		String line;
		while((line = file.readLine()) != null)
			System.out.println(line);
		file.close();
	}
}