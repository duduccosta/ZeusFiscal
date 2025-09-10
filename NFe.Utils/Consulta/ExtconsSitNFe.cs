using DFe.Utils;
using NFe.Classes.Servicos.Consulta;
using System.Threading;
using System.Threading.Tasks;

namespace NFe.Utils.Consulta
{
    public static class ExtconsSitNFe
    {
        /// <summary>
        ///     Converte o objeto consSitNFe para uma string no formato XML
        /// </summary>
        /// <param name="pedConsulta"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto consSitNFe</returns>
        public static string ObterXmlString(this consSitNFe pedConsulta)
        {
            return FuncoesXml.ClasseParaXmlString(pedConsulta);
        }

#if NET5_0_OR_GREATER
        /// <summary>
        ///     Converte o objeto consSitNFe para uma string no formato XML
        /// </summary>
        /// <param name="pedConsulta"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto consSitNFe</returns>
        public async static Task<string> ObterXmlStringAsync(this consSitNFe pedConsulta, CancellationToken cancellationToken = default)
        {
            return await FuncoesXml.ClasseParaXmlStringAsync(pedConsulta, cancellationToken).ConfigureAwait(false);
        }
#endif
    }
}