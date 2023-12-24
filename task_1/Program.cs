using System;
using System.Net.Http.Headers;
int N;
Random rnd = new Random();
N = rnd.Next(5,10);
string[] mas_1 = new string[N];

int count=0;
Console.WriteLine($"Введите {N} строк:");
for (int i=0; i<N;i++){
    mas_1[i] = Console.ReadLine();
    if(mas_1[i]!= null & mas_1[i].Length<=3){
        count++;
    }
}
string[] mas_2 = new string[count];
count=0;
for (int i=0; i<N;i++){
    if(mas_1[i]!= null & mas_1[i].Length<=3){
        mas_2[count] = mas_1[i];
        Console.Write($"{mas_2[count]} ");
        count++;
    }
}
