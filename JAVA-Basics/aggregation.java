class operation
{
    int square(int n)
    {
       return n*n;
    }
}
class area
{
    double pi=3.14;
    operation op=new operation();
    int areaOfsquare(int radius)
    {
       rsquare=op.square(radius);
       return pi*rsquare;
    }
}
public class test
{
    public static void main(String args[])
    area object=new area();
    double res=object.areaOfsquare(5);
    System.out.println("Area of circle is : "+res)
}