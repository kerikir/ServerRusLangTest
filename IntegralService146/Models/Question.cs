namespace TestService.Models
{
    public class Question
    {
        public int QuestionId { get; set; }

        public string TextQuestion { get; set; }

        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int AnswerRight { get; set; }
    }
}
