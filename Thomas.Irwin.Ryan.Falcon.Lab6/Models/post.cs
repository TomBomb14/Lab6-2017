namespace Thomas.Irwin.Ryan.Falcon.Lab6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class post
    {
        public int postId { get; set; }

        public string title { get; set; }

        public string category { get; set; }

        public string content { get; set; }

        public int? author_userId { get; set; }

        public virtual user user { get; set; }
    }
}
