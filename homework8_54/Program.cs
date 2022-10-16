Console.WriteLine("задание 56");
            int[,] matrix = {{1,4,7,2},
                             {5,9,2,3},
                             {8,4,2,4},
                             {5,2,6,7}};
 
            int sum = 0;
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                int temp = 0;
                for (int j = 0; j < 4; j++)
                {
                    temp += matrix[j, i];
                }
                if (temp > sum)
                {
                    sum = temp;
                    index = i;
                }
            }
            Console.WriteLine("Строка: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(matrix[i, index]);
 
         }  
    