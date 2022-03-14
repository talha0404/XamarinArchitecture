using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinArchitecture.Models
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Guid { get; set; }
        public string ActionUser { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedDate { get; set; }
        public long? ModifiedDate { get; set; }
        public int isSync { get; set; }
        public int? UserId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
