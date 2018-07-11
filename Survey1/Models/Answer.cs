namespace Survey1.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }        
        public int SurveyId { get; set; }
        public int UserId { get; set; }
        public string Choice { get; set; }


    }
}
