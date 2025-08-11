using System.ComponentModel.DataAnnotations;

namespace DFQuestionnaireV1.Models
{
    public class InputQuestion
    {
        [Required]
        public string Text { get; set; } = string.Empty;   // The prompt shown to the user

        [Required(ErrorMessage = "Please enter an answer.")]
        [StringLength(500)]                                // Adjust max length as needed
        public string Answer { get; set; } = string.Empty; // The user's typed answer

        public string Placeholder { get; set; } = "";      // Optional helper text

        public InputQuestion() { }

        public InputQuestion(string text, string placeholder = "")
        {
            Text = text;
            Placeholder = placeholder;
        }
    }
}
