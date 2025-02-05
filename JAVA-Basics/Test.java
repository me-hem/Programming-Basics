import java.util.*;
//Define DivisionException class here
import java.util.*;
//define user defined exception InvalidInputEx
class InvalidInputEx extends Exception{
	public InvalidInputEx(String msg, Throwable cause){
		super(msg, cause);
	}
}


//define the class IntList with 
class IntList{
	//instance variable of int[]
	private int[] arr = new int[5];
	
	//and methods set_value, getArray()
	public void set_value(int i, int val){
		try{
			if(i < 0 || i > 4)
				throw new InvalidInputEx("invalid index input", new ArrayIndexOutOfBoundsException("Index " + i +" out of bounds for length 5"));
			arr[i] = val;
		}catch(InvalidInputEx ex){
			System.out.println(ex);
		}
	}
	
	public int[] getArray(){
		return arr;
	}
}
class Test{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        IntList ilist = new IntList();
        try {
            for(int i = 0; i < 5; i++) {			
                int n = sc.nextInt();
                int m = sc.nextInt();
                ilist.set_value(n, m);
            }
        }
        catch(InvalidInputEx e) {
            System.out.println(e.getMessage());
            Throwable ori = e.getCause();
            System.out.println(ori.getMessage());
        }	
        int[] i_arr = ilist.getArray();
        for(int i = 0; i < i_arr.length; i++)
            System.out.print(i_arr[i] + " ");
    }
}