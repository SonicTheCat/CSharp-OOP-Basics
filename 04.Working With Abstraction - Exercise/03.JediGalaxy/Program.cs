namespace _03.JediGalaxy
{
    using System;
    using System.Linq;

    public class Program
    {
        static private int[][] matrix;
      
        public static void Main()
        {
            var sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            FillUpMatrix(sizes);

            Playa ivo = new Playa();
            Evil evil = new Evil();
        
            string command;
            while ((command = Console.ReadLine()) != "Let the Force be with you")
            {
                ivo.SetCoordinates(command);
                evil.SetCoordinates(Console.ReadLine()); 

                evil.DestroyStars(matrix);
                ivo.CollectPoints(matrix);             
            }
            Console.WriteLine(ivo.Points);
        }    
        static void FillUpMatrix(int[] sizes)
        {
            var rows = sizes[0];
            var cols = sizes[1];
            matrix = new int[rows][];
            for (int r = 0, n = 0; r < matrix.Length; r++)
            {
                var currentRow = new int[cols];
                for (int c = 0; c < cols; c++)
                {
                    currentRow[c] = n++;
                }
                matrix[r] = currentRow;
            }
        }
    }
}