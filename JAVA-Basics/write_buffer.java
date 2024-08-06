import java.io.*;

public class write_buffer
{
		public static void main(String[] s) throws IOException
		{
			BufferedWriter file = new BufferedWriter(new FileWriter("./newfile.txt", true));
			file.write("Just Chill...");
			file.close();
		}
}