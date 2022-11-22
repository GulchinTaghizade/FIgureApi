using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.RequestModels
{
    public class CircleRequestModel
    {
        [Required]
        public double centerX { get; set; }
        [Required]
        public double centerY { get; set; }
        [Required]
        public double coordinateX { get; set; }
        [Required]
        public double coordinateY { get; set; }
    }
}

