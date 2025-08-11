using System.ComponentModel.DataAnnotations;

namespace DFQuestionnaireV1.Models
{
    public class SelectOneQuestion
    {
        /// <summary>
        /// The question text to display.
        /// </summary>
        [Required]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// The list of options the user can choose from.
        /// </summary>
        [Required]
        public List<string> Options { get; set; } = new();

        /// <summary>
        /// The single option the user has selected.
        /// </summary>
        [Required(ErrorMessage = "Please pick one of the options.")]
        public string? SelectedOption { get; set; } 

        public SelectOneQuestion() { }

        public SelectOneQuestion(string text, IEnumerable<string> options)
        {
            Text = text;
            Options = new List<string>(options);
            
        }
    }
}
