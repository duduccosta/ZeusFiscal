using DFe.Utils;
using NFe.Classes.Servicos.AdmCsc;
using System.Threading;
using System.Threading.Tasks;

namespace NFe.Utils.AdmCsc
{
    public static class ExtAdmCscNFCe
    {
        /// <summary>
        ///     Converte o objeto admCscNFCe para uma string no formato XML
        /// </summary>
        /// <param name="admCscNFCe"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto admCscNFCe</returns>
        public static string ObterXmlString(this admCscNFCe admCscNFCe)
        {
            return FuncoesXml.ClasseParaXmlString(admCscNFCe);
        }

#if NET5_0_OR_GREATER
        /// <summary>
        ///     Converte o objeto admCscNFCe para uma string no formato XML
        /// </summary>
        /// <param name="admCscNFCe"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto admCscNFCe</returns>
        public async static Task<string> ObterXmlStringAsync(this admCscNFCe admCscNFCe, CancellationToken cancellationToken = default)
        {
            return await FuncoesXml.ClasseParaXmlStringAsync(admCscNFCe, cancellationToken).ConfigureAwait(false);
        }
#endif
    }
}