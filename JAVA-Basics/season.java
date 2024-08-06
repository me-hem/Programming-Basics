import java.util.*;
class season{
	
	public static void main(String s[]){
		Scanner scan = new Scanner(System.in);
		System.out.printf("To know the season, enter month number : ");
		int month = scan.nextInt();
		String season = " ";
		switch(month)
		{
			case 1:
			case 2:
			case 12:
				season = "Winter";
				break;
			case 3:
			case 4:
			case 5:
				season = "Spring";
				break;
			case 6:
			case 7:
			case 8:
				season = "Summer";
				break;
			case 9:
			case 10:
			case 11:	
				season = "Autumn";
				break;
			default:
				System.out.println("Invalid input!!!");	
		}
		System.out.println("The season of month"+month+"is"+season);
		
}
}