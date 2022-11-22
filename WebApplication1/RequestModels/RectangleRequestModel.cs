using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.RequestModels
{
    public class RectangleRequestModel
    {
        [Required]
        public double firstCoordinateX { get; set; }
        [Required]
        public double firstCoordinateY { get; set; }
        [Required]
        public double secondCoordinateX { get; set; }
        [Required]
        public double secondCoordinateY { get; set; }
        [Required]
        public double thirdCoordinateX { get; set; }
        [Required]
        public double thirdCoordinateY { get; set; }
        [Required]
        public double fourthCoordinateX { get; set; }
        [Required]
        public double fourthCoordinateY { get; set; }
    }
}

