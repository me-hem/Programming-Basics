import java.io.*;
public class write_file
{
	public static void main(String[] s) throws IOException
	{
		FileOutputStream fout = new FileOutputStream("./newfile.txt",true);
		String word = "Hey, it's me: Mr Hem";
		char[] chr_array = word.toCharArray();
		for(char i: chr_array)
			fout.write(i);
		fout.close();	
	}
}