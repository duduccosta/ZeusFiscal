using DFe.Utils;
using NFe.Classes.Servicos.Autorizacao;
using System.Threading;
using System.Threading.Tasks;

namespace NFe.Utils.Autorizacao
{
    public static class ExtenviNFe3
    {
        /// <summary>
        ///     Converte o objeto enviNFe3 para uma string no formato XML
        /// </summary>
        /// <param name="pedEnvio"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto enviNFe3</returns>
        public static string ObterXmlString(this enviNFe3 pedEnvio)
        {
            return FuncoesXml.ClasseParaXmlString(pedEnvio);
        }

#if NET5_0_OR_GREATER

        /// <summary>
        ///     Converte o objeto enviNFe3 para uma string no formato XML
        /// </summary>
        /// <param name="pedEnvio"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto enviNFe3</returns>
        public async static Task<string> ObterXmlStringAsync(this enviNFe3 pedEnvio, CancellationToken cancellationToken = default)
        {
            return await FuncoesXml.ClasseParaXmlStringAsync(pedEnvio, cancellationToken).ConfigureAwait(false);
        }
#endif
    }
}