﻿namespace TraversolCoreProje.Dto.Dtos
{
    public class ResultContactDto:ResultBaseDto
    {
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }
    }
}
