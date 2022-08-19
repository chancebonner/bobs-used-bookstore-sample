﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels.Books
{
    public class Condition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Condition_Id { get; set; }

        public string ConditionName { get; set; }

        [Timestamp] public byte[] RowVersion { get; set; }
    }
}