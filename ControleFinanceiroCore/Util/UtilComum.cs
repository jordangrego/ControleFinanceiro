using System;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Globalization;
using System.IO;

namespace ControleFinanceiroCore.Util
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class UtilComum
    {
        /// <summary>
        /// Recupera a descrição do Enum.
        /// </summary>
        /// <param name="value">Enum para recuperar a descrição.</param>
        /// <returns>Descrição do Enum.</returns>
        public static string RecuperaDescricaoEnum(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        /// <summary>
        /// Grava Arquivo no File System.
        /// </summary>
        /// <param name="conteudo">Arquivo que será gravado.</param>
        /// <param name="pathArquivo">Caminho onde será gravado na HD.</param>
        public static void GravaArquivoFileSystem(byte[] conteudo, string pathArquivo)
        {
            System.IO.FileStream fileStream = new System.IO.FileStream(pathArquivo, FileMode.Create, FileAccess.Write);
            fileStream.Write(conteudo, 0, conteudo.Length);
            fileStream.Close();
        }

        /// <summary>
        /// Cria pasta.
        /// </summary>
        /// <param name="folder">Path da Pasta.</param>
        public static void CriarPasta(string folder)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }

        /// <summary>
        /// Deleta todo o conteúdo de uma pasta.
        /// </summary>
        /// <param name="folder">Caminho da Pasta.</param>
        public static void DeletaPasta(string folder)
        {
            if (Directory.Exists(folder))
            {
                Directory.Delete(folder, true);
            }
        }

        /// <summary>
        /// Recupera a Extensão do Arquivo.
        /// </summary>
        /// <param name="nomeArquivo">Nome do Arquivo.</param>
        /// <returns>Extensão do Arquivo.</returns>
        public static string RecuperaExtensao(string nomeArquivo)
        {
            return nomeArquivo.Substring(nomeArquivo.LastIndexOf("."), nomeArquivo.Length - nomeArquivo.LastIndexOf(".")).Replace(".", string.Empty).ToUpper();
        }

        /// <summary>
        /// Recupera Nome Arquivo Sem Extensao.
        /// </summary>
        /// <param name="nomeArquivo">Nome do Arquivo.</param>
        /// <returns>Nome Arquivo Sem Extensao.</returns>
        public static string RecuperaNomeArquivoSemExtensao(string nomeArquivo)
        {
            return nomeArquivo.Substring(0, nomeArquivo.LastIndexOf("."));
        }

        /// <summary>
        /// Remover Acentos.
        /// </summary>
        /// <param name="text">Texto que terá o acento removido.</param>
        /// <returns>Texto sem acentos.</returns>
        public static string RemoverAcentos(this string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(letter);
                }
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Recupera a descrição do Enum.
        /// </summary>
        /// <param name="value">Dominiopara recuperar a descrição.</param>
        /// <returns>Descrição do Domínio.</returns>
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
