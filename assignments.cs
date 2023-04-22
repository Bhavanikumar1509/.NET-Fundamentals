
/*N=5
11
1122
112233
11223344
1122334455*/
using System;
class Pattern{
    static void Main(String[] args){
        int n=int.Parse(Console.ReadLine());
        for(int i=1;i<=n;i++){
            for(int j=1;j<=i;j++){
                Console.Write(j+""+j);
            }
            Console.WriteLine("");
        }
    }
}


/* 
     *
     ***
    ****
   ******

 */

using System;
class Pattern{
    static void Main(String[] args){
       int n = 4;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n-i; j++)
    {
        Console.Write(" ");
    }
    if(i==1 || i==2){
        for (int k = 1; k <= 2*i-1; k++)
        {
       
        Console.Write("*");
        }
        Console.WriteLine("");
    }
    else{
        for (int k = 1; k <= 2*i-2; k++)
        {
       
        Console.Write("*");
        }
        
        Console.WriteLine("");
    
    }
    
}
    Console.WriteLine();
    }
};



/*N=5
1 2 4 7 11*/

using System;
class Pattern{
    static void Main(String[] args){
       int n=int.Parse(Console.ReadLine());
        int i=1,j=1;
        while(i<=n){
            Console.Write(j+" ");
            j+=i;
            i++;

        }
    }
}

/*N=9
9 1 8 2 7 3 6 4 5*/

using System;
class Pattern{
    static void Main(String[] args){
        int n=int.Parse(Console.ReadLine());
        int i=n,j=1;
         while(i>j){
            Console.Write(i+" "+j+" ");
            i--;
            j++;
         }
         Console.Write(i);

    }
}


/*   *****
     *    *
     *    *
     *    *
     ******

*/

using System;
class Pattern{
    static void Main(String[] args){
        int n=int.Parse(Console.ReadLine());
        for(int i=1;i<=n;i++){
            for(int j=1;j<=n;j++){
                if(i==1 || i==n|| j==1||j==n){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }


    }
}




/*Tringle Pattern
     *
   * *
  *  *
 *   *
*    *
 *   *
  *  *
   * *
     *



*/

using System;
class Pattern{
    static void Main(String[] args){
       int n = 5;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    for (int k = 1; k < i; k++)
    {
        Console.Write(" ");
    }
    if (i > 1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = n - 1; i >= 1; i--)
{
    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    for (int k = 1; k < i; k++)
    {
        Console.Write(" ");
    }
    if (i > 1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

    }
};



using System;
class Arrays{
    static void Main(String[] args){
        int[] a={11,22,33,44,55};
        left(a);
        Right(a);
        
    }
    
    public static void Left(int[] a){
        int n=a.Length;
        int temp = a[0];
        for (int i = 1; i < n; i++)
        {
            a[i - 1] = a[i];
        }
        a[a.Length - 1] = temp;
        Console.WriteLine("Left Shift");
        display(a);
    }
    public static  void display(int[] a){
        foreach(int n in a){
        Console.Write(n + " ");
    }
    }
    public static void Right(int[] a){
        int n=a.Length;
        int temp=a[n-1];
        for(int i=n-1;i>0;i--){
            a[i]=a[i-1];
        }
        a[0]=temp;
        Console.WriteLine("\nRight Shift");
        display(a);
        
    }
   
}


/**/

using System;
class Arrays{
    static void inputArray(int[] arr){
        Console.WriteLine("ENter array elements:");
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.Int32(Console.ReadLine());
        }
    }
    static void Main(String[] args){
        Console.WriteLine("enter size of a :")
        int n;
        n=Convert.Int32(Console.ReadLine());
        int[] a=new int[n];
        inputArray(a);
        Console.WriteLine("enter size of b :")
        int m;
        m=Convert.Int32(Console.ReadLine());
        int[] b=new int[m];
        inputArray(a);
        int[] b=new int[]
        int[] c=new int[n + m];

        int j = 0;
    for (int i = 0; i < a.Length; i++)
    {
        c[j++] = a[i];
        if (i < b.Length)
        {
            c[j++] = b[i];
        }
    }
    display(c);
    
    }
    public static void display(int[] c){
        foreach(int k in c){
        Console.Write(k+" ");
    }
    }
    
    
}

/**/

using System;
class Arrays{
    static void Main(){
        int[] a=new int[40];
        int choice=0;
        while(choice!=4){
             Console.WriteLine("\n 1. insert \n 2.Delete\n 3.Display 4. Exit");
            Console.Write("Enter your Choice:");
        choice=Convert.ToInt32(Console.ReadLine());
           
            if(choice ==1){
                Console.Write("Enter the element to Insert:");
                int ele=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the index:");
                 int index=Convert.ToInt32(Console.ReadLine());
                Insert(a,ele,index);
            }
            else if(choice==2){
                Console.Write("Enter the index:");
                 int index=Convert.ToInt32(Console.ReadLine());
                 Delete(a,index);
                 
            }
            
            
            
            
           else if(choice==3){
                display(a);
            }


        }


    }

    public static void Insert(int[] arr,int ele, int index){
        
        if(index<0){
            Console.WriteLine("Invalid");
        }
       
            if(index< arr.Length && index >arr.Length){
                Console.WriteLine("Invalid");
            }else{

               for (int i = arr.Length - 1; i > index; i--)
                {
                arr[i] = arr[i - 1];
                }
                arr[index] = ele;
            }


    }
    public static void Delete(int[] arr,int index){
        int temp=0;
        for(int i=0;i<arr.Length;i++){
        
            if(i==index && arr[i]!=0){
                temp=arr[i];
                arr[i]=0;

            }
            
        }
        Console.WriteLine("Deleted"+temp+" at index:"+ index);
    }



    public static void display(int[] a){
         foreach(int k in a){
             if(k!=0){
                Console.Write(k+" ");
             }
    }

}
}





