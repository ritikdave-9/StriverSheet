using System;
using System.Collections.Generic;

namespace Striver{
     
class Program
{

   public class Solution {
    public void setAllRowsZero(int row) {

    }
    public void SetZeroes(int[][] matrix) {
        List<int> rows  = new List<int>(new int[matrix[0].Length,1);
        List<int> cols = new List<int>(matrix.Length,1);

        for (int i = 0;i < matrix.Length; i++) {
            for (int j = 0;j < matrix[i].Length;j++){
                if(matrix[i][j] == 0){
                    cols[i] = 0;
                    rows[j] = 0;
                }
            }

        }

        for(int i = 0;i < cols.Length;i++){
            if(cols[i]==0){
                
            }
            
        }
        
    }
} 
    static void Main(string[] args)
    {

        List<int> rows =List<int>();
        List<int> cols =List<int>();


    }
}
}
