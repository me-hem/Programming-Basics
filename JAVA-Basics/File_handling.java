import java.io.*;

public class File_handling 
{
	public static void main(String s[]) throws IOException
	{
		File f = new File("D:/Programming/Java/file.txt");
		f.createNewFile();
		System.out.println("File exists: "+f.exists());
		System.out.println("File size: "+f.length());
		System.out.println("File name: "+f.getName());
		System.out.println("Can file read: "+f.canWrite());
		f.delete();
		System.out.println("Deletion done!\nFile exists: "+f.exists());
	}
}