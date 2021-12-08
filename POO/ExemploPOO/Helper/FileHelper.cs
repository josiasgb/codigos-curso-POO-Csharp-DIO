using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListaDiretorios(string caminho) 
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);
            foreach(var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        internal void CriarDiretorio(Func<string, string, string> combine)
        {
            throw new NotImplementedException();
        }   

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
            File.WriteAllText(caminho, conteudo);
            }
        }
    }
}