using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR2
{
    internal abstract class BaseDevice
    {
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Length { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseDevice(double width, double thickness, double length, DateTime creationDate)
        {
            this.Width = width;
            this.Thickness = thickness;
            this.Length = length;
            this.CreationDate = creationDate;
        }
        
        public BaseDevice() : this(0, 0, 0, DateTime.Now)
        {
        }

        public string Info()
        {
            return $"Пристрій із назвою {this.GetType().Name}, шириною: {Width}, довжиною: {Length}, товщиною: {Thickness}, датою виготовлення: {CreationDate.ToShortDateString()}";
        }

        public double CountVolume()
        {
            return Width * Thickness * Length;
        }

        public TimeSpan CountDeviceAge()
        {
            if(DateTime.Now > CreationDate)
                return DateTime.Now - CreationDate;
            else
                return TimeSpan.Zero;
        }
    }
}
