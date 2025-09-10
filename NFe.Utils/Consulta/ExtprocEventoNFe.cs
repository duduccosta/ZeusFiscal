using System.IO;
using System.Threading.Tasks;
using System.Threading;
using DFe.Utils;
using NFe.Classes.Servicos.Consulta;

namespace NFe.Utils.Consulta
{
    public static class ExtprocEventoNFe
    {
        /// <summary>
        ///     Converte o objeto procEventoNFe para uma string no formato XML
        /// </summary>
        /// <param name="procEventoNFe"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto procEventoNFe</returns>
        public static string ObterXmlString(this procEventoNFe procEventoNFe)
        {
            return FuncoesXml.ClasseParaXmlString(procEventoNFe);
        }

        /// <summary>
        ///     Coverte uma string XML no formato procEventoNFe para um objeto procEventoNFe
        /// </summary>
        /// <param name="procEventoNFe"></param>
        /// <param name="xmlString"></param>
        /// <returns>Retorna um objeto do tipo procEventoNFe</returns>
        public static procEventoNFe CarregarDeXmlString(this procEventoNFe procEventoNFe, string xmlString)
        {
            var s = FuncoesXml.ObterNodeDeStringXml(typeof(procEventoNFe).Name, xmlString);
            return FuncoesXml.XmlStringParaClasse<procEventoNFe>(s);
        }

        public static procEventoNFe CarregardeStream(this procEventoNFe procEventoNFe, StreamReader stream)
        {
            var s = FuncoesXml.ObterNodeDeStream(typeof(procEventoNFe).Name, stream);
            return FuncoesXml.XmlStringParaClasse<procEventoNFe>(s);
        }

#if NET5_0_OR_GREATER
        /// <summary>
        ///     Converte o objeto procEventoNFe para uma string no formato XML
        /// </summary>
        /// <param name="procEventoNFe"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto procEventoNFe</returns>
        public async static Task<string> ObterXmlStringAsync(this procEventoNFe procEventoNFe, CancellationToken cancellationToken = default)
        {
            return await FuncoesXml.ClasseParaXmlStringAsync(procEventoNFe, cancellationToken).ConfigureAwait(false);
        }

        public async static Task<procEventoNFe> CarregardeStreamAsync(this procEventoNFe procEventoNFe, StreamReader stream, CancellationToken cancellationToken = default)
        {
            var s = await FuncoesXml.ObterNodeDeStreamAsync(typeof(procEventoNFe).Name, stream, cancellationToken).ConfigureAwait(false);
            return FuncoesXml.XmlStringParaClasse<procEventoNFe>(s);
        }
#endif
    }
}