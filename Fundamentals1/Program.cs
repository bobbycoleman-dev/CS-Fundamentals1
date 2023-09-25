// 1. Create loop from 1-255
// for(int i = 1; i <= 255; i++){
//     Console.WriteLine(i);
// }
// int i = 1;
// int end = 255;
// while(i <= end){
//     Console.WriteLine(i);
//     i++;
// }

// 2. Create loop that generates 5 random numbers between 10 & 20
// for(int i = 0; i < 5; i++){
//     Random rand = new();
//     Console.WriteLine(rand.Next(10,21));
// }
// int i = 0;
// int end = 5;
// while(i < end){
//     Random rand = new();
//     Console.WriteLine(rand.Next(10,21));
//     i++;
// }

// 3. Print random values together
// int sum = 0;
// for(int i = 0; i < 5; i++){
//     Random rand = new();
//     sum += rand.Next(10,21);
// }
// Console.WriteLine(sum);
// int i = 0;
// int end = 5;
// int sum = 0;
// while(i < end){
//     Random rand = new();
//     sum += rand.Next(10,21);
//     i++;
// }
// Console.WriteLine(sum);

// 4. Create loop that prints values 1 to 100 that are divisible by 3 or 5, but not both
// for(int i = 1; i <= 100; i++){
//     if (i % 3 == 0 && i % 5 == 0){
//         i++;
//         continue;
//     }else if(i % 3 == 0){
//         Console.WriteLine(i);
//     } else if(i % 5 == 0){
//         Console.WriteLine(i);
//     }
// }
// int i = 1;
// int end = 100;
// while(i <= end){
//     if (i % 3 == 0 && i % 5 == 0){
//         i++;
//         continue;
//     } else if(i % 3 == 0){
//         Console.WriteLine(i);
//     } else if(i % 5 == 0){
//         Console.WriteLine(i);
//     } 
//     i++;
// }

// 4. Modify loop to print Fizz for 3 and Buzz for 5
// for(int i = 1; i <= 100; i++){
//     if (i % 3 == 0 && i % 5 == 0){
//         i++;
//         continue;
//     }else if(i % 3 == 0){
//         Console.WriteLine("Fizz");
//     } else if(i % 5 == 0){
//         Console.WriteLine("Buzz");
//     }
// }
// int i = 1;
// int end = 100;
// while(i <= end){
//     if (i % 3 == 0 && i % 5 == 0){
//         i++;
//         continue;
//     } else if(i % 3 == 0){
//         Console.WriteLine("Fizz");
//     } else if(i % 5 == 0){
//         Console.WriteLine("Buzz");
//     } 
//     i++;
// }

// 4. Modify loop to print FizzBuzz for multiples of 3 and 5
// for(int i = 1; i <= 100; i++){
//     if (i % 3 == 0 && i % 5 == 0){
//         Console.WriteLine("FizzBuzz");
//     } else if(i % 3 == 0){
//         Console.WriteLine("Fizz");
//     } else if(i % 5 == 0){
//         Console.WriteLine("Buzz");
//     } 
// }
// int i = 1;
// int end = 100;
// while(i <= end){
//     if (i % 3 == 0 && i % 5 == 0){
//         Console.WriteLine("FizzBuzz");
//     } else if(i % 3 == 0){
//         Console.WriteLine("Fizz");
//     } else if(i % 5 == 0){
//         Console.WriteLine("Buzz");
//     } 
//     i++;
// }