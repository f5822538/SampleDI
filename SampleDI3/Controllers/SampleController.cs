using Microsoft.AspNetCore.Mvc;
using SampleDI3.Interface;
using SampleDI3.Services;

namespace SampleDI3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        public readonly SampleService _sampleService;
        #region DI
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampleService"></param>
        /// <param name="transient"></param>
        /// <param name="scoped"></param>
        /// <param name="singleton"></param>
        public SampleController(SampleService sampleService, ITransient transient, IScoped scoped, ISingleton singleton)
        {
            _sampleService = sampleService;
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;
        }

        [HttpGet]
        public ActionResult<IDictionary<string, string>> Get()
        {
            var serviceHashCode = _sampleService.GetSampleHashCode();
            var controllerHashCode = $"Transient: {_transient.GetHashCode()}, " +
                                        $"Scoped: {_scoped.GetHashCode()}, " +
                                        $"Singleton: {_singleton.GetHashCode()}";

            var result = new Dictionary<string, string>();
            result.Add("Service", serviceHashCode);
            result.Add("Controller", controllerHashCode);

            return result;
        }

    }
}
