//Program to understand strings and implement their methods.
class string
{
	public static void main(String d[])
	{
		String str1 = "Hey Mr!", str2 = "How are you?";
		String str3 = str1 + " " + str2;
		System.out.println("str1 is "+str1);
		System.out.println("str2 is "+str2);
		System.out.println("str3 = srt1+str2 is "+str3);
		System.out.println("Length of  "+str1+" is " + str1.length());
		System.out.println("In "+str2+" character at 5th position is "+str2.charAt(4));
		System.out.println("str1 == str2 "+(str1 == str2));
		System.out.println("str1 != str3 "+(str1 != str3));
		System.out.println(str1+" concatination with "+str2+" is "+str1.concat(str2));
		
	}
}