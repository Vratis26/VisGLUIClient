using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS.VisualizationUI.Model
{
    internal class Coordination
    {
        public string Type { get; set; }
        public int PointAX { get; set; }
        public int PointAY { get; set; }
        public int? PointBX { get; set; }
        public int? PointBY { get; set; }
    }
}
