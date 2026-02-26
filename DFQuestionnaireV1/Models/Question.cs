namespace DFQuestionnaireV1.Models
{
    
    public interface IQuestion
    {
       
        int Id { get; set; }
        public string Text { get; set; }

        public string Answer { get; set; }
    }
    public class Question : IQuestion
    {

        public int Id { get; set; }
        public string Text { get; set; }

        public string Answer { get; set; }

        /*public Question()
        {
            Id = Guid.NewGuid();
        }*/
    }
    

}
