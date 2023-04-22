/*Bubble sort      check adjacent elements*/

using System;
class Sorting{
    static void inputArray(int[] arr){
        Console.WriteLine("ENter array elements:");
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.Int32(Console.ReadLine());
        }
    }
    static void Main(String[] args){
        Console.WriteLine("enter size of array :")
        int n;
        n=Convert.Int32(Console.ReadLine());
        int[] a=new int[n];
        inputArray(a);
        Bubble(a);
        display(a);
    }
    static void Bubble(int[] arr){
        int n=arr.Length;
        int cmp=n-1;
        for(int i=0;i<n-1;i++){
            for(int j=0;j<cmp-i;j++){
            if(arr[j]>arr[j+1]){
                swap(arr[j],arr[j+1]);

            }
            }

        }
    }
    static void swap(int a,int b){
        int temp;
        temp=a;
        a=b;
        b=temp;
    }
    public static void display(int[] c){
        foreach(int k in c){
        Console.Write(k+" ");
    }
    }


}


/*Insertion Sort*/

using System;
class Sorting{
    static void inputArray(int[] arr){
        Console.WriteLine("ENter array elements:");
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.Int32(Console.ReadLine());
        }
    }
    static void Main(String[] args){
        Console.WriteLine("enter size of array :")
        int n;
        n=Convert.Int32(Console.ReadLine());
        int[] a=new int[n];
        inputArray(a);
        Insertion(a);
        display(a);
    }
    static void Insertion(int[] arr){
        int n=arr.Length;
        for(i=1;i<n;i++)
        {
	        key = a[i];
	        j = i-1;
            while(j>=0 && a[j]>key)
            {
                a[j+1] = a[j];
                j--;
            }
	    a[j+1]=key;
        }
    }
    public static void display(int[] c){
        foreach(int k in c){
        Console.Write(k+" ");
    }
    }
}











/*Linear Search*/

using System;
class Sorting{
    static void inputArray(int[] arr){
        Console.WriteLine("ENter array elements:");
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
    static void Main(String[] args){
        Console.WriteLine("enter size of array :");
        int n;
        n=Convert.ToInt32(Console.ReadLine());
        int[] a=new int[n];
        inputArray(a);
        Console.WriteLine("ENter key to Search");
        int key=Convert.ToInt32(Console.ReadLine());
        Linear(a,key);
    }
    static void Linear(int[] arr, int key){
        int count=0;
        for(int i=0;i<=arr.Length;i++){
            if(arr[i]==key){
                Console.WriteLine("Element Found at index "+ i);
                count+=1;
            }
        }
        if(count<=0){
            Console.WriteLine("Element not found at any index");
        }

    }



/**/

using System;
class Sorting{
    static void inputArray(int[] arr){
        Console.WriteLine("ENter array elements:");
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
    static void Main(String[] args){
        Console.WriteLine("enter size of array :");
        int n;
        n=Convert.ToInt32(Console.ReadLine());
        int[] a=new int[n];
        inputArray(a);
        Console.WriteLine("ENter key to Search");
        int key=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Binary(a,key));
    }

    static int Binary(int[] arr, int key){
        int n=arr.Length;
        int low=0;
        int high=n-1, j,k;
        while (low <= high) {
        int mid = (int) (low + high) / 2;

        if (arr[mid] == key) {
            return mid; 
            for(j=mid;j>=0 && arr[j]==key;j--);
            for(k=mid;k<n&& arr[k]==key;j++);
            Console.Write("We found the element from "+ j+1+" to ");
            Console.WriteLine(k-1);
        
        }
        else if (arr[mid] > key) {
            high = mid - 1; 
        }
        else {
            low = mid + 1; 
        }
    }

    return -1; 
        
 }
}