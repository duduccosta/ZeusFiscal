using DFe.Utils;
using NFe.Classes.Servicos.AdmCsc;
using System.Threading;
using System.Threading.Tasks;

namespace NFe.Utils.AdmCsc
{
    public static class ExtretAdmCscNFCe
    {
        /// <summary>
        ///     Carrega um objeto do tipo retAdmCscNFCe a partir de uma string no formato XML
        /// </summary>
        /// <param name="retAdmCscNFCe"></param>
        /// <param name="xmlString"></param>
        /// <returns>Retorna um objeto retAdmCscNFCe com as informações da string XML</returns>
        public static retAdmCscNFCe CarregarDeXmlString(this retAdmCscNFCe retAdmCscNFCe, string xmlString)
        {
            return FuncoesXml.XmlStringParaClasse<retAdmCscNFCe>(xmlString);
        }

        /// <summary>
        ///     Converte um objeto do tipo retAdmCscNFCe para uma string no formato XML com os dados do objeto
        /// </summary>
        /// <param name="retDownloadNFe"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto retAdmCscNFCe</returns>
        public static string ObterXmlString(this retAdmCscNFCe retDownloadNFe)
        {
            return FuncoesXml.ClasseParaXmlString(retDownloadNFe);
        }

#if NET5_0_OR_GREATER

        /// <summary>
        ///     Converte um objeto do tipo retAdmCscNFCe para uma string no formato XML com os dados do objeto
        /// </summary>
        /// <param name="retDownloadNFe"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto retAdmCscNFCe</returns>
        public async static Task<string> ObterXmlStringAsync(this retAdmCscNFCe retDownloadNFe, CancellationToken cancellationToken = default)
        {
            return await FuncoesXml.ClasseParaXmlStringAsync(retDownloadNFe, cancellationToken).ConfigureAwait(false);
        }
#endif
    }
}