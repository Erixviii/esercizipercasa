using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Arraycircolare
{

    public static class Program 
    {
        public static void Main() 
        {
           int[] arr =new int[5];
           int c=0;
           for(int i=0;i<10;i++)
           {
           	
           	if(i%5==0) {c=0;
           	foreach(int item in arr){
        		Console.Write(item.ToString());}
           	}
           	Console.Write("\n");
           	arr[c]=i;
           	c++;
           	
           }
           foreach(int item in arr)
        		Console.Write(item.ToString());
           	
        }
    }
}
