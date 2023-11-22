﻿namespace my_app_backend.Models
{
    public class BookInventoryHistoryDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public int Direction { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
