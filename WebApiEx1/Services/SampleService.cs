using SampleDI3.Interface;

namespace SampleDI3.Services
{
    public class SampleService
    {
        #region DI
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;
        #endregion

        /// <summary>
        /// SampleService
        /// </summary>
        /// <param name="transient"></param>
        /// <param name="scoped"></param>
        /// <param name="singleton"></param>
        public SampleService(ITransient transient,
                                IScoped scoped,
                                ISingleton singleton)
        {
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;
        }

        /// <summary>
        /// GetSampleHashCode
        /// </summary>
        /// <returns></returns>
        public string GetSampleHashCode()
        {
            return $"Transient: {_transient.GetHashCode()}, " +
                    $"Scoped: {_scoped.GetHashCode()}, " +
                    $"singleton: {_singleton.GetHashCode()}";
        }

    }
}
