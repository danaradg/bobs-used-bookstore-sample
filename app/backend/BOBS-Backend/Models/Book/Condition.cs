﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreBackend.Models.Book
{
    public class Condition
    {
        /*
         * Condition Model
         */

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Condition_Id { get; set; }

        public string ConditionName { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}