namespace WebMvc.Interfaces
{
    public interface IPessoa
    {
        string Fala();
        void Escuta();
    }

    public class MatheusPessoa : IPessoa
    {
        public string Fala(){
            // implementação
        }
        public void Escuta(){
            //implementa
        }
    }

    public class MudoPessoa : IPessoa
    {
        private string Fala()
        {
            throw new NotImplementedException();
        }

        public void Escuta(){
            // implementação
        }
    }
}