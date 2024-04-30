using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223051.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Ricky Renaldi","1302223051", new List<string>(){"KPL", "PBO", "BasDat" }, 2022),
            new Mahasiswa("Nicholas Xavier Robinson Silalahi", "1302220078", new List<string>(){"KPL", "PBO", "BasDat" }, 2022),
            new Mahasiswa("Syauqi Dhiya Ulhaq", "1302220112", new List<string>(){"KPL", "PBO", "BasDat" }, 2022)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
