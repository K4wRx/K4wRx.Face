using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using K4wRx.Extensions;
using Microsoft.Kinect.Face;

namespace K4wRx.Extensions
{
    public static class FaceReaderExtension
    {
        public static IObservable<FaceFrameArrivedEventArgs> AsObservable(this KinectSensor sensor)
        {
            throw new Exception("this function is not enabled");
        }
    }
}
