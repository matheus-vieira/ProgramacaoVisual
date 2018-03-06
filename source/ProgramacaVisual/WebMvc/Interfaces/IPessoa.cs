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
            return string.Empty;
        }
        public void Escuta(){
            //implementa
        }
    }

    public class MudoPessoa : IPessoa
    {
        public string Fala()
        {
            return string.Empty;
        }

        public void Escuta(){
            // implementação
        }
    }
}