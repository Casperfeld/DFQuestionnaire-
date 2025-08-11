using System.ComponentModel.DataAnnotations;

namespace DFQuestionnaireV1.Models
{
    public class PercentQuestion
    {
        public string Text { get; set; } = string.Empty;

        [Range(0, 100, ErrorMessage = "Please enter a value between 0 and 100.")]
        public int Answer { get; set; }

    }
}
