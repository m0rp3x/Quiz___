using ConsoleApp12;

namespace quiz
{
    public class  Questions
    {
            


        public Questions  (int id, String question, string answer)
        {
            Id = id;
            Question = question;
            Answer = answer;
        }
        
        public string GetQuestion() => Question;
        public string GetAnswer() => Answer;
        
        public string Question { get; set; }
        public string Answer { get; set; }

        public int Id { get; set; }


       
    }
}
 
