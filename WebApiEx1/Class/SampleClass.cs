using SampleDI3.Interface;

namespace SampleDI3.Class
{
    public class SampleClass: IScoped, ISingleton, ITransient
    {
        public SampleClass()
        {
            //...
        }
    }
}
