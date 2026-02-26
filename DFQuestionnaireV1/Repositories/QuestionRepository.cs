using System.Collections.Generic;
using DFQuestionnaireV1.Models;


namespace DFQuestionnaireV1.Repositories
{

    public interface IQuestionRepository {

        IReadOnlyList<YesNoQuestion> GetPotentialConsequences();

        IReadOnlyList<YesNoQuestion> GetProjectDecisions();

        IReadOnlyList<YesNoQuestion> GetGameComplexities();

        string ProjectValueText();
        string MgmtRadarText();
        string InteractionRiskText();

    }


    public class QuestionRepository : IQuestionRepository {
    
        private static readonly List<YesNoQuestion> _potentialConsequences = new List<YesNoQuestion>
        {
            new YesNoQuestion {Id=1, Text = "Delays"},
            new YesNoQuestion {Id=2, Text = "Worsened competitive position"},
            new YesNoQuestion {Id=3, Text = "Poor deals (inadequate terms, leaving value on the table)" },
            new YesNoQuestion {Id=4, Text = "Reputational damage" },
            new YesNoQuestion {Id=5, Text = "Partner (supplier) misalignment" },
            new YesNoQuestion {Id=6, Text = "Missed opportunities" }


        };

        private static readonly List<YesNoQuestion> _projectDecisions = new List<YesNoQuestion>
        {

            new YesNoQuestion {Id=7, Text = "Deal-making/negotiations" },
            new YesNoQuestion {Id=8, Text = "JV/ Strategic Alliance Strategy" },
            new YesNoQuestion {Id=9, Text = "Alliance/Partner Management" },
            new YesNoQuestion {Id=10, Text = "Competitive positioning and/or risk" },
            new YesNoQuestion {Id=11, Text = "Market Entry" },
            new YesNoQuestion {Id=12, Text = "Country Entry" },
            new YesNoQuestion {Id=13, Text = "Political risk/governing relations" },
            new YesNoQuestion {Id=14, Text = "Bidding" },
            new YesNoQuestion {Id=15, Text = "Procurement" },
            new YesNoQuestion {Id=16, Text = "Litigation" },
            new YesNoQuestion {Id=17, Text = "Other (note in comment box)" },
            new YesNoQuestion {Id=18, Text = "Country Entry" }


        };

        private static readonly List<YesNoQuestion> _gameComplexities = new List<YesNoQuestion>
        {

            new YesNoQuestion {Id=19, Text = "Private information"},
            new YesNoQuestion {Id=20, Text = "Learning event uncertainties"},
            new YesNoQuestion {Id=21, Text = "Significant uncertainties at the end of the game"}

        };

        public string ProjectValueText() => "Enter the potential value:";
        public string MgmtRadarText() => "Enter the amount needed to get on management’s radar:";
        public string InteractionRiskText() => "Enter the Interaction Risk (%):";


        public IReadOnlyList<YesNoQuestion> GetPotentialConsequences() => _potentialConsequences;

        public IReadOnlyList<YesNoQuestion> GetProjectDecisions() => _projectDecisions;

        public IReadOnlyList<YesNoQuestion> GetGameComplexities() => _gameComplexities;
    }
}
