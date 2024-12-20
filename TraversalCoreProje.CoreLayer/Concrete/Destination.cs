﻿using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class Destination : BaseEntity
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }

        public DateTime Date { get; set; }
        public int? GuideId { get; set; }
        public virtual Guide Guide { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

    }
}
