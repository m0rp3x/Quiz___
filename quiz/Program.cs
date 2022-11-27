using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using quiz;

namespace ConsoleApp12
{
    internal class quizz
    {
        public static  void Main(string[] args)
        {
            int ans = 0;
            List<Questions> ms = new List<Questions>
            {
                new Questions(1,"Какое название имеют конспирологические теории по поводу высадки NASA на луне?","лунный заговор"),
                new Questions(2,"Последння буква в Алфавите","Я"),
                new Questions(3,"Сколько лет длилось крепостное право?","212"),
                new Questions(4,"Улукоморье","Дуб зелёный"),
                
            };

            List<string?> answer = new List<string?>();
                
            foreach (var i in ms )
            {
                Console.WriteLine($"{i.Question}");
                Console.WriteLine();
                  answer.Add(Console.ReadLine());
                  if (answer.Contains(i.Answer))
                  {
                      ans += 1;
                  }
            }

            Console.WriteLine();
            Console.WriteLine($"Вы ответили правильно на {ans} что является { ans * 100 / ms.Count}%");
            
            
            File.WriteAllText(@"C:\Users\koval\RiderProjects\quiz\quiz\quiz.json", JsonSerializer.Serialize(ms));
            File.WriteAllText(@"C:\Users\koval\RiderProjects\quiz\quiz\answer.json", JsonSerializer.Serialize(answer));
            
       
        }
        
        
    }
    
}