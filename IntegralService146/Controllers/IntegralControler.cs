using IntegralService146.Models;
using IntegralService146.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TestService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IntegralService146.Controllers
{
    [Route("api/integral")]
    [ApiController]
    public class IntegralControler : ControllerBase
    {
        private ICalculatorService _calculatorService;
        private ILogger _logger;
        public IntegralControler(ICalculatorService calcServ)
        {
            _calculatorService = calcServ;

            ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });
            _logger = loggerFactory.CreateLogger<IntegralControler>();
        }

        // POST api/<IntegralControler>
        [HttpPost]
        public ActionResult<IntegralOutputData> Post([FromBody] IntegralInputData inputData)
        {
            _logger.LogInformation($"Received request with input data: (LowerLimit = {inputData.DownLimit}, " +
                $"UpperLimit = {inputData.UpLimit}, Partitions = {inputData.N}, Function = {inputData.FuncIntegral})\n");

            IntegralOutputData result = _calculatorService.Calculate(inputData);

            _logger.LogInformation($"Calculated value: (Result = {result.Result}) with input data: (LowerLimit = {inputData.DownLimit}, " +
                $"UpperLimit = {inputData.UpLimit}, Partitions = {inputData.N}, Function = {inputData.FuncIntegral})\n");

            return result;
        }
    }


    [Route("api/question")]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        private readonly QuestionContext _context;

        public QuestionController(QuestionContext context)
        {
            _context = context;
        }

        // Post: api/question
        [HttpGet]
        public async Task<ActionResult<Question>> GetQuestions()
        {
            var questions = await _context.Questions.ToListAsync();

            List<Question> randomQuestions = new List<Question>();

            int[] generateQuestions = new int[10];
            Random random = new Random();

            int[] values = new int[questions.Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i;
            }
            int temp;
            int index;
            for (int i = 0; i < values.Length; i++)
            {
                index = random.Next(20);
                temp = values[index];
                values[index] = values[i];
                values[i] = temp;
            }
            
            for (int i = 0; i < generateQuestions.Length; i++)
            {
                randomQuestions.Add(questions[values[i]]);
            }

            return Ok(randomQuestions);
        }


        [HttpPost]
        public async Task<ActionResult<QuestionOutputData>> EvaluateAnswersAsync([FromBody] QuestionInputData answer)
        {
            var questions = await _context.Questions.ToListAsync();

            QuestionOutputData questionOutputData = new QuestionOutputData();
            questionOutputData.Result = 0.0;

            for (int i = 0; i < answer.Indicies.Count; i++)
            {
                if (answer.Answers[i] == questions[answer.Indicies[i] - 1].AnswerRight) 
                {
                    questionOutputData.Result += 0.5;
                }
            }


            return Ok(questionOutputData);
        }
    }
}
