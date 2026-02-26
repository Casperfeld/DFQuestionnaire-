using System;

namespace DFQuestionnaireV1.Models
{
    /// <summary>
    /// Holds answers across wizard steps and computes the final result.
    /// Register once in Program.cs:
    ///   builder.Services.AddScoped<DFQuestionnaireV1.Models.QuestionnaireState>();
    /// </summary>
    public class QuestionnaireState
    {
        // -------- Step 1 ----------
        public bool? Q1YesNo { get; set; }
        public int? ValueQ { get; set; }
        public int? PercentQ { get; set; } // 0..100

        // -------- Step 2 ----------
        // 1=Conservative, 2=Balanced, 3=Aggressive, 4=Unsure
        public int? Preference { get; set; }
        public string? Notes { get; set; }

        // -------- Results ----------
        public double Score { get; private set; }

        /// <summary>
        /// Run your real math here. This is an example formula.
        /// </summary>
        public void Recompute()
        {
            var yes = Q1YesNo == true ? 1.0 : 0.0;
            var val = (double?)ValueQ ?? 0.0;
            var pct = (double?)PercentQ ?? 0.0;

            
            var prefWeight = Preference switch
            {
                1 => 0.8, // Conservative
                2 => 1.0, // Balanced
                3 => 1.2, // Aggressive
                4 => 0.9, // Unsure
                _ => 1.0
            };

            Score = (yes * 10 + val + pct / 100.0) * prefWeight;
        }

        // Models/QuestionnaireState.cs

        public Guid InstanceId { get; } = Guid.NewGuid();   // debug only

        public HashSet<int> PotentialConsequencesYes { get; } = new();

        public HashSet<int> ProjectDecisionsYes { get; } = new();

        public HashSet<int> GameComplexitiesYes { get; } = new();
        public string? InteractionDynamics { get; set; }  // "LIMITED" | "SIGNIFICANT" | "BID"

        public int? ProjectValue { get; set; }
        public int? InteractionRisk { get; set; }
        public int? MgmtRadar { get; set; }

        public bool IsConsequenceSelected(int id) => PotentialConsequencesYes.Contains(id);
        /// <summary>
        /// Clear all answers and computed values.
        /// </summary>
        public void Reset()
        {
            Q1YesNo = null;
            ValueQ = null;
            PercentQ = null;
            Preference = null;
            Notes = null;
            Score = 0;
        }

        // -------- Optional validation helpers ----------
        public bool IsPart1Valid()
            => Q1YesNo.HasValue
               && ValueQ.HasValue
               && PercentQ.HasValue
               && PercentQ is >= 0 and <= 100;

        public bool IsPart2Valid()
            => Preference.HasValue;

        public bool IsAllValid()
            => IsPart1Valid() && IsPart2Valid();
    }
}

