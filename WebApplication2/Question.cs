namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [StringLength(10)]
        public string QuestionId { get; set; }

        [Required]
        public string QuestionText { get; set; }

        [Required]
        [StringLength(10)]
        public string ChoiceId { get; set; }
    }
}
