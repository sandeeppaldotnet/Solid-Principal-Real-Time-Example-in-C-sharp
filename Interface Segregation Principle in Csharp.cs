using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_Real_Time_Example_in_C_sharp
{
    internal class Interface_Segregation_Principle_in_Csharp
    {
        public interface ISampleMobile
        {
          
            void Message(string message);
        }
        interface ISmartPhone
        {
            void Camera(string content);
            void Music(string content);
            void Internete(string surfing);

        }
        interface ITelephone
        {
            void Call(string content);
        }
        public class SampleMobile : ISampleMobile, ITelephone
        {
            public void Call(string content)
            {
                throw new NotImplementedException();
            }

            public void Message(string message)
            {
                throw new NotImplementedException();
            }
        }
        public class SmartPhone : ISmartPhone, ISampleMobile, ITelephone
        {
            public void Call(string content)
            {
                throw new NotImplementedException();
            }

            public void Camera(string content)
            {
                throw new NotImplementedException();
            }

            public void Internete(string surfing)
            {
                throw new NotImplementedException();
            }

            public void Music(string content)
            {
                throw new NotImplementedException();
            }

            void ISampleMobile.Message(string message)
            {
                throw new NotImplementedException();
            }
        }
    }
}
