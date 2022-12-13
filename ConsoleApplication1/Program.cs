using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Publisher publisher = new Publisher();
            //Subscriber subscriber = new Subscriber();

            //publisher.VideoEncoded += subscriber.OnVideoEncoded;
            //publisher.VideoEncoded += subscriber.OnVideoEncoded;
            //publisher.VideoEncoded += subscriber.OnVideoEncoded;
            //publisher.Encode();

            Delegates delegatesClass = new Delegates();

            Console.ReadLine();

        }
   }

    class Publisher
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode ()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }

    class Subscriber
    {
        public void OnVideoEncoded (object source, EventArgs args)
        {
            Console.WriteLine("Video is encoded");
            Console.ReadLine();
        }
    }
}
