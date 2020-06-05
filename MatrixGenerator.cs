using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;       
        private Random generator; 
 
        private MatrixGenerator()         
        {         
            this.generator = new Random();  
        } 
 
        public static MatrixGenerator GetInstance()     
        {          
            if (instance == null)          
            {       
                instance = new MatrixGenerator();   
            }      
            return instance; 
        }  

        public double NextDouble()         
        {           
            return this.generator.NextDouble();   
        }
        public double[][] CreateMatrix(int rows, int columns)
        {
            double[,] newMatrix = new double[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for(int j=0;j < columns; j++)
                {
                newMatrix[i,j] = NextDouble();
                }
            }
            return newMatrix[rows,columns];
        }
    }
}
