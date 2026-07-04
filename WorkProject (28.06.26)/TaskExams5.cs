using System;
using System.Collections.Generic;
using System.Text;

namespace WorkProject__28._06._26_
{
    internal class TaskExams5
    {
        async static Task Main(string[] args)
        {
            await DownloadUpdateAsync();
            Console.WriteLine("Мы выполняем асинхронную работу!");

            async Task DownloadUpdateAsync()
            {
                Console.WriteLine("Начинаю скачивание");
                await Task.Run(Print);
            }
            void Print()
            {
                Console.WriteLine("Всем привет!");
                Task.Delay(3000);
            }
        }
    }
}
