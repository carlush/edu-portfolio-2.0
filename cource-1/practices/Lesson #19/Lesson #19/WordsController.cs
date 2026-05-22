using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WordsController : ControllerBase
    {
        private static readonly List<string> _words = new List<string>
        {
            "яблоко", "банан", "программирование", "кошка", "собака", "солнце", "космос"
        };
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllWords()
        {
            return Ok(_words);
        }
        [HttpPost]
        public ActionResult<IEnumerable<string>> AddWord([FromBody] string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return BadRequest("Слово не может быть пустым.");
            }

            _words.Add(word);
            return Ok(_words);
        }
        [HttpDelete("{index:int}")]
        public ActionResult<IEnumerable<string>> DeleteWord(int index)
        {
            if (index < 0 || index >= _words.Count)
            {
                return NotFound($"Слово с индексом {index} не найдено. Доступные индексы: 0 - {_words.Count - 1}");
            }

            _words.RemoveAt(index);
            return Ok(_words);
        }
    }
}