using System.ComponentModel.DataAnnotations;

namespace DFQuestionnaireV1.Models
{
    public class DropDownQuestion
    {
        /// <summary>
        /// The question text to display above the dropdown.
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// The list of options the user can choose from.
        /// </summary>
        [Required]
        public List<string> Options { get; set; } = new List<string>();

        /// <summary>
        /// The option the user has selected.
        /// </summary>
        [Required(ErrorMessage = "Please pick one of the options.")]
        public string SelectedOption { get; set; }

        public DropDownQuestion() { }

        public DropDownQuestion(string text, IEnumerable<string> options)
        {
            Text = text;
            Options = new List<string>(options);
            // default to first choice so the dropdown won't be empty
            SelectedOption = Options.Count > 0 ? Options[0] : null;
        }
    }
}
