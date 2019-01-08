namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer
    {
        [StringLength(10)]
        public string AnswerId { get; set; }

        [Required]
        public string AnswerText { get; set; }

        [Required]
        [StringLength(10)]
        public string QuestionId { get; set; }

        [Required]
        [StringLength(10)]
        public string AuserId { get; set; }

        [Required]
        [StringLength(10)]
        public string Userid { get; set; }
    }
}
