using MailApi.Estrutura;
using MailApi.VM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailApi.Controllers
{
    [Route("api/email")]
    [ApiController]
    public class ControladorEmail : ControllerBase
    {
        private readonly IEmail _mailService;

        public ControladorEmail(IEmail EmailServices)
        {
            _mailService = EmailServices;
        }

        [HttpPost]  
        
        public IActionResult EnviarEmail([FromBody] ViewModelEmail viewModelEmail)
        {
            _mailService.EnviarEmail(viewModelEmail.Nome, viewModelEmail.EmailContato, viewModelEmail.Assunto);

            return Ok();
        }
    }

    
}
