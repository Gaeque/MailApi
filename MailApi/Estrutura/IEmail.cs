namespace MailApi.Estrutura
{
    public interface IEmail
    {
        void EnviarEmail(string? nome, string? emailContato, string? assunto);
    }
}
 